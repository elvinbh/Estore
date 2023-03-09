using Estore.DAL;
using Estore.Models;
using Estore.ViewModels.BlogViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(
                   new BlogVM
                   {
                       InstagramFeeds = await _context.InstagramFeeds.ToListAsync(),
                       Posts = await _context.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).ToListAsync(),
                     


                   }
                ) ;
        }


       
        public async Task<IActionResult> Blogdetails(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            if (await _context.Posts.FindAsync(Id) == null)
            {
                return BadRequest();
            }

            BlogVM blogVM = new BlogVM
            {

                Post = await _context.Posts.Include(b => b.BlogComments).Include(b => b.BlogWriter).Include(c => c.PostCategories).ThenInclude(c => c.Category).FirstOrDefaultAsync(c => c.Id == Id),




            };


         
           



            if (!ModelState.IsValid)
            {
                return NotFound();

            }

            return View(blogVM);
        }







        [HttpPost]
        public async Task<IActionResult> CreateComment(int Id, BlogComments blogComments)
        {
            //if (!ModelState.IsValid)
            //{

            //    return BadRequest();
            //}


            if (await _context.Posts.FindAsync(Id) == null)
            {
                return BadRequest();
            }
            Post Post = await _context.Posts.Include(b=>b.BlogComments).Include(b=>b.BlogWriter).FirstOrDefaultAsync(c => c.Id == Id);
            var comments = Post.BlogComments;



           
             blogComments = new BlogComments {
                 Name= blogComments.Name,
                 SurName= blogComments.SurName,
                 Text= blogComments.Text,
                 Email = blogComments.Email,
                CreatedAt = DateTime.Now,
                PostId = Post.Id,
                Post = Post


             };
            comments.Append(blogComments);




      





            await _context.BlogComments.AddAsync(blogComments);
            _context.Update(Post);
            await _context.SaveChangesAsync();
            return RedirectToAction("Blogdetails",new {Id= Post.Id});


        }
    







        [HttpGet]
        public async Task<IActionResult> SubscribeEmail()
        {
            return RedirectToAction();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubscribeEmail(BlogSubscribe blogSubscribe)
        {


            blogSubscribe.EmailStatus = true;

           
            if (!ModelState.IsValid && (blogSubscribe.Email.Length<1))
            {
                ModelState.AddModelError("Email","Email dogru daxil edilmeyib!");
            }

            await _context.BlogSubscribes.AddAsync(blogSubscribe);
            await _context.SaveChangesAsync();

            return RedirectToAction();


        }
    }
}
