using Estore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Estore.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

                
    }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<AboutText> AboutTexts { get; set; }
        public virtual DbSet<AboutVideo> AboutVideos { get; set; }
        public virtual DbSet<AboutShopInfo> AboutShopInfos { get; set; }
        public virtual DbSet<AboutShopItem> AboutShopItems { get; set; }
        public virtual DbSet<Subscribe> Subscribes { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<BlogComments> BlogComments { get; set; }
        public virtual DbSet<BlogWriter> BlogWriters { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<InstagramFeed> InstagramFeeds { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostCategories> PostCategories { get; set; }
        public virtual DbSet<PostTags> PostTags { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<BlogSubscribe> BlogSubscribes { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<ShopMethod> ShopMethods { get; set; }
        public virtual DbSet<LatestSubscribe> LatestSubscribes { get; set; }
        public virtual DbSet<BestCollectionModel> BestCollectionModels { get; set; }
        public virtual DbSet<BestCollectionitems> BestCollectionitems { get; set; }
        public virtual DbSet<BestProduct> BestProducts { get; set; }
        public virtual DbSet<ShopCategory> ShopCategories { get; set; }
        public virtual DbSet<HomeSlider> HomeSliders { get; set; }
        public virtual DbSet<FilterItems> FilterItems { get; set; }
        public virtual DbSet<FilterCategory> FilterCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Productimages> Productimages { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Checkout> Checkouts { get; set; }























    }

}