using LetsHungry.Core.Models;
using LetsHungry.DataAccessLayer.Configurations;
using LetsHungry.DataAccessLayer.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer
{
    public class LetsHungryDbContext : DbContext
    {
        public LetsHungryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Raiting> Raitings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))

            {

                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            int i1 = 1;
            int i2 = 2;
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
            modelBuilder.ApplyConfiguration(new RezervationConfiguration());
            modelBuilder.ApplyConfiguration(new RaitingConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new CommentSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new LocationSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new RaitingSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new ProductCategorySeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new OrderSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new RezervationSeed(new int[] { i1, i2 }));
            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { i1, i2 }));
        }

    }
}
