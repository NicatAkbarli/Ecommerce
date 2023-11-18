using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Ecommercy;Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=True");
        }
    

    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<Affiliate> Affiliates { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<CommentPhoto> CommentPhotos { get; set; }
    public DbSet<Follower> Followers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Shop> Shops { get; set; }
   public DbSet<User> Users { get; set; }
    }
}