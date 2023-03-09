using Estore.DAL;
using Estore.ViewModels.ContactViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                 new ContactVM
                 {
                     Galleries = await _context.Galleries.ToListAsync(),
                     ContactInfos = await _context.ContactInfos.ToListAsync(),
                     Map = await _context.Maps.FirstOrDefaultAsync()





                 }

                );
        }
    }
}
