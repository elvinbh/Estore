using Estore.DAL;
using Estore.ViewModels.CategoryViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                 new CategoryVM
                 {
                     Galleries = await _context.Galleries.ToListAsync(),
                     ShopMethods = await _context.ShopMethods.ToListAsync(),
                     LatestSubscribe = await _context.LatestSubscribes.FirstOrDefaultAsync(),






                 }

                );
        }


    }
}
