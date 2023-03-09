using Estore.DAL;
using Estore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estore.ViewComponents
{
    public class FilterViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public FilterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string Float)
        {

           IEnumerable<FilterCategory>FilterCategories  = await _context.FilterCategories.Include(f => f.FilterItems).ToListAsync();
            foreach(FilterCategory category in FilterCategories)
            {
                category.Float = Float;
            }
            return View(await Task.FromResult(FilterCategories));

        }
    }
}
