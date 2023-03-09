using Estore.DAL;
using Estore.Models;
using Estore.ViewModels.BasketViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            string strBasket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> products = null;

            if (strBasket == null)
            {
                products = new List<BasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(strBasket);
            }
            



            return View(products);

        }

        public async Task<IActionResult> AddBasket(int? Id,int Quantity)
        {
            if (Id == null)
                return NotFound();

            Product product = await _context.Products.Include(p => p.Productimages)
             .FirstOrDefaultAsync(p => p.Id == Id);
            if (product == null)
                return NotFound();

            string strBasket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> products = null;

            if (strBasket == null)
            {
                products = new List<BasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(strBasket);
            }
            if(Quantity == 0)
            {
                Quantity = 1;
            }

            BasketVM basketVM = new BasketVM
            {
                Id = (int)Id,
                Title = product.Name,
                MainImage = product.Productimages.FirstOrDefault().Img,
                Price = product.Price,
                Quantity = Quantity
            };

            if (products.Any(p => p.Id == Id))
            {
                products.FirstOrDefault(p => p.Id == Id).Quantity += Quantity;
            }
            else
            {
                products.Add(basketVM);
            }

            string strProduct = JsonConvert.SerializeObject(products);

            HttpContext.Response.Cookies.Append("basket", strProduct, new CookieOptions { MaxAge = TimeSpan.FromMinutes(100) });





            return RedirectToAction("Index", "Product");
        }

        public IActionResult ShowBasket()
        {
            string strBasket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> products = null;

            if (strBasket == null)
            {
                products = new List<BasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(strBasket);
            }
            return Json(products);
        }
        public IActionResult RemoveCart(int? Id)
        {
            if(Id == null)
            {
                return BadRequest(Id);
            }
            string strBasket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(strBasket);
           BasketVM cart = products.Find(p => p.Id == Id);
            if(cart == null)
            {
                return NotFound();
            }
            products.Remove(cart);
            string strProduct = JsonConvert.SerializeObject(products);

            HttpContext.Response.Cookies.Append("basket", strProduct, new CookieOptions { MaxAge = TimeSpan.FromMinutes(100) });
            return RedirectToAction("Index", "Product");

        }
    }
}
