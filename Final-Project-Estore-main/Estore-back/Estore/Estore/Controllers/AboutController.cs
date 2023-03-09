using Estore.DAL;
using Estore.ViewModels.AboutViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(
                 new AboutVM
                 {
                     AboutText = await _context.AboutTexts.Include(a => a.AboutVideo).FirstOrDefaultAsync(),
                     AboutShopInfo = await _context.AboutShopInfos.Include(a => a.Items).FirstOrDefaultAsync(),
                     Subscribe = await _context.Subscribes.FirstOrDefaultAsync(),



                 }

                );
        }
    }
}
