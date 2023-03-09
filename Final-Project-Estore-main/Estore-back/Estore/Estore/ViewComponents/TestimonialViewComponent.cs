using Estore.DAL;
using Estore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Estore.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public TestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            IEnumerable<Testimonial>testimonial = await _context.Testimonials.ToListAsync();
            return View(await Task.FromResult(testimonial));

        }
    }
}
