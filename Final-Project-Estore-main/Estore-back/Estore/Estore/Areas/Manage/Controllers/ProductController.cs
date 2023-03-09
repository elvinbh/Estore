using Estore.DAL;
using Estore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Extensions;
using Pustok.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.Where(p=>p.Isdeleted==false).Include(p=>p.Productimages).OrderByDescending(s=>s.Id).Take(8).ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.ProductCategories.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = await _context.ProductCategories.ToListAsync();

            if (product.ProductImagesFile.Length> 5)
            {
                ModelState.AddModelError("ProductImagesFile", "Maksimum 5 Sekil Yukleye Bilersiniz");
                return View(product);
            }

            if (!ModelState.IsValid)
                return View(product);

            if (product.ProductCategoryId != null && !await _context.ProductCategories.AnyAsync(a => a.Id == product.ProductCategoryId))
            {
                ModelState.AddModelError("ProductCategoryId", "Categoriya Mutleq Secilmelidi");
                return View(product);
            }

            string filePath = Path.Combine(_env.WebRootPath, "images");
            if (product.ProductImagesFile.Length > 0)
            {
               
                List<Productimages> productImages = new List<Productimages>();

                foreach (IFormFile file in product.ProductImagesFile)
                {
                    if (!file.CheckContentType("image"))
                    {
                        ModelState.AddModelError("ProductImagesFile", $"{file.FileName} tipini Duzgun Secin");
                        return View(product);
                    }

                    if (file.CheckLength(200))
                    {
                        ModelState.AddModelError("ProductImagesFile", $"{file.FileName} Uzunlugu Maksimum 200 kb Ola Biler");
                        return View(product);
                    }

                    Productimages productImage = new Productimages
                    {
                        Img = await file.SaveFileAsync(filePath)
                    };

                    productImages.Add(productImage);
                }

                product.Productimages = productImages;
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Update(int? Id)
        {

            ViewBag.Categories = await _context.ProductCategories.ToListAsync();

            if (Id == null)
                return NotFound();

            Product product = await _context.Products.Include(p => p.Productimages).FirstOrDefaultAsync(p => p.Id == Id);

            if (product == null)
                return NotFound();

            return View(product);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id, Product product)
        {
            ViewBag.Categories = await _context.ProductCategories.ToListAsync();


            if (Id == null)
                return NotFound();

            Product dbProduct = await _context.Products.Include(p => p.Productimages).FirstOrDefaultAsync(p => p.Id == Id);

            if (dbProduct == null)
                return NotFound();

            if (!ModelState.IsValid)
                return View(dbProduct);

         

            int canUpload = 5 - dbProduct.Productimages.Count();

            if (product.ProductImagesFile != null && canUpload < product.ProductImagesFile.Length)
            {
                ModelState.AddModelError("ProductImagesFile", $"Maksumum {canUpload} Shekil Upload Ede Bilersinizi !!!!!!!");
                return View(dbProduct);
            }

            string filePath = Path.Combine(_env.WebRootPath, "images");

            

            if (product.ProductImagesFile.Length > 0)
            {
                foreach (IFormFile file in product.ProductImagesFile)
                {
                    if (!file.CheckContentType("image"))
                    {
                        ModelState.AddModelError("ProductImagesFile", $"{file.FileName} tipini Duzgun Secin");
                        return View(product);
                    }

                    if (file.CheckLength(200))
                    {
                        ModelState.AddModelError("ProductImagesFile", $"{file.FileName} Uzunlugu Maksimum 200 kb Ola Biler");
                        return View(product);
                    }

                    dbProduct.Productimages.Append(new Productimages
                    {
                        Img = await file.SaveFileAsync(filePath)
                    });
                }
            }

            dbProduct.Count = product.Count;
            dbProduct.Price = product.Price;
            dbProduct.Description = product.Description;
            dbProduct.Name = product.Name;
            dbProduct.Baskets = product.Baskets;
            dbProduct.ProductCategory = product.ProductCategory;


            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProductImage(int? Id)
        {
            if (Id == null)
                return NotFound();

            Productimages productImage = await _context.Productimages.FirstOrDefaultAsync(p => p.Id == Id);
            if (productImage == null)
                return NotFound();

            string filePath = Path.Combine(_env.WebRootPath, "image");

            Helper.DeleteFile(filePath, productImage.Img);

            int productId = productImage.ProductId;

            _context.Productimages.Remove(productImage);
            await _context.SaveChangesAsync();


            return RedirectToAction("Update",new { Id=productId});
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            Product product = await _context.Products.Where(n => n.Isdeleted == false).Include(p=>p.Productimages).FirstOrDefaultAsync(n => n.Id == id);
            if (product == null) return NotFound();
            string path = Path.Combine(_env.WebRootPath, "images");

            Helper.DeleteFile(path, product.Productimages.FirstOrDefault().Img);
            product.Isdeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
