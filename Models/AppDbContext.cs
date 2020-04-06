using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebsite.Models.ViewModels;

namespace TrainingWebsite.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Personalised Clothing", Description = "Personalise Any Item of clothing for any occasion" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Personalised Soft Toys", Description = "Personalise Any Soft Toy for any occasion" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Personalised Storage", Description = "Personalise Any Item of storage for any item" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Personalised Ornaments", Description = "Personalise Any Ornament for any occasion" });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                ProductId = 1,
                ProductName = "Personalised Baby Vest",
                ShortDescription = "Create your own personalised baby vest",
                LongDescription = " Choose your color, choose your style and your message and we will create it for your perfect gift",
                categoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimages-na.ssl-images-amazon.com%2Fimages%2FI%2F61zpI2doUxL._AC_UL1200_.jpg&imgrefurl=https%3A%2F%2Fwww.amazon.co.uk%2FShopagift-Happy-Birthday-Daddy-Bodysuit%2Fdp%2FB075V38KC3&tbnid=BCPVLap64oCY9M&vet=12ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw..i&docid=Sab7IpAO82DQ6M&w=974&h=1200&q=baby%20vest&ved=2ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw",
                InStock = true,
                IsProductsOfTheWeek = true,
                ImageThumbnailUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimages-na.ssl-images-amazon.com%2Fimages%2FI%2F61zpI2doUxL._AC_UL1200_.jpg&imgrefurl=https%3A%2F%2Fwww.amazon.co.uk%2FShopagift-Happy-Birthday-Daddy-Bodysuit%2Fdp%2FB075V38KC3&tbnid=BCPVLap64oCY9M&vet=12ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw..i&docid=Sab7IpAO82DQ6M&w=974&h=1200&q=baby%20vest&ved=2ahUKEwjGu_6SktPoAhUw1eAKHQVKBysQMyhOegUIARDfAw",
            });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                ProductId = 2,
                ProductName = "Personalised Make-up Bag",
                ShortDescription = "Create your own personalised Make-up bag",
                LongDescription = " Choose your color, choose your style and your message and we will create it for your perfect gift",
                categoryId = 2,
                ImageUrl = "pic-2.jpg",
                InStock = true,
                IsProductsOfTheWeek = true,
                ImageThumbnailUrl = "pic-2.jpg",
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                ProductId = 3,
                ProductName = "Personalised Water Bottle",
                ShortDescription = "Create your own personalised Water Bottle",
                LongDescription = " Choose your color, choose your style and your message and we will create it for your perfect gift",
                categoryId = 2,
                ImageUrl = "pic-3.jpg",
                InStock = true,
                IsProductsOfTheWeek = true,
                ImageThumbnailUrl = "pic-3.jpg",
            });
            modelBuilder.Entity<Products>().HasData(new Products
            {
                ProductId = 4,
                ProductName = "Personalised Container",
                ShortDescription = "Create your own personalised Containers",
                LongDescription = " Choose your color, choose your style and your message and we will create it for your perfect gift",
                categoryId = 2,
                ImageUrl = "pic-1.jpg",
                InStock = true,
                IsProductsOfTheWeek = true,
                ImageThumbnailUrl = "pic-1.jpg",
            });
        }
    }
}



                 
                 
                