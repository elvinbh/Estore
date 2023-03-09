using Estore.DAL;
using Estore.ViewModels.HomeViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                 new HomeVM
                 {
                     Galleries = await _context.Galleries.ToListAsync(),
                     ShopMethods = await _context.ShopMethods.ToListAsync(),
                     LatestSubscribe = await _context.LatestSubscribes.FirstOrDefaultAsync(),
                     BestCollection = await _context.BestCollectionModels.Include(b=>b.Collectionitems).FirstOrDefaultAsync(),
                     BestProduct = await _context.BestProducts.FirstOrDefaultAsync(),
                     ShopCategories = await _context.ShopCategories.ToListAsync(),
                     HomeSliders = await _context.HomeSliders.ToListAsync(),
                   







                 }

                );
        }
    }
}
