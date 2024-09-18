using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixedShop.Models
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //dec
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Item>()
            //    .Property(p => p.Price)
            //    .HasColumnType("decimal(18,2");

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Monitor", Description = "" },
                    new Category { CategoryId = 2, CategoryName = "Keyboard", Description = "" },
                    new Category { CategoryId = 3, CategoryName = "Mouse", Description = "" },
                    new Category { CategoryId = 4, CategoryName = "Headphone", Description = "" },
                    new Category { CategoryId = 5, CategoryName = "Printer", Description = "" }
                );

            modelBuilder.Entity<Item>().HasData(
                    new Item { ItemId = 1, Name = "JBL Headset", Price = 75.99m, IsRecommended = true, Make = "JBL", Description = "Black, Noise Cancelling", ImageUrl = "\\Images\\Catalog\\jblheadset.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\jblheadset.jpg",  CategoryId = 4 },
                    new Item { ItemId = 2, Name = "Canon Printer", Price = 299.99m, IsRecommended = false, Make = "Canon", Description = "Wireless, Color All-in-One", ImageUrl = "\\Images\\Catalog\\canonprinter.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\canonprinter.jpg",  CategoryId = 5 },
                    new Item { ItemId = 3, Name = "Logitech Wireless Mouse", Price = 15.99m, IsRecommended = false, Make = "Logitech", Description = "Wireless Mouse, 3 Year Battery Life, Blue", ImageUrl = "\\Images\\Catalog\\logitech-wireless-mouse.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\logitech-wireless-mouse.jpg",  CategoryId = 3 },
                    new Item { ItemId = 4, Name = "Logitech High Performance Mouse", Price = 49.99m, IsRecommended = false, Make = "Logitech", Description = "Wired Gaming Mouse, 11 Programmable Buttons", ImageUrl = "\\Images\\Catalog\\Logitech Performance Mouse.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Logitech Performance Mouse.jpg",  CategoryId = 3 },
                    new Item { ItemId = 5, Name = "Sony Headphones", Price = 79.99m, IsRecommended = false, Make = "Sony", Description = "Noise Cancelling Headphones, Black/Red", ImageUrl = "\\Images\\Catalog\\Sony Headphones.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Sony Headphones.jpg",  CategoryId = 4 },
                    new Item { ItemId = 6, Name = "Samsung Odyssey Montior", Price = 119.99m, IsRecommended = true, Make = "Samsung", Description = "Gaming Monitor, 2560x1440, 144Hz, Curved", ImageUrl = "\\Images\\Catalog\\Samsung Odyssey Montior.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Samsung Odyssey Montior.jpg", CategoryId = 1 },
                    new Item { ItemId = 7, Name = "Acer Full HD Monitor", Price = 119.99M, IsRecommended = false, Make = "acer", Description = "Zero Frame Monitor, 1920x1080", ImageUrl = "\\Images\\Catalog\\Acer Full HD Monitor.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Acer Full HD Monitor.jpg",  CategoryId = 1 },
                    new Item { ItemId = 8, Name = "Logitech Keyboard", Price = 14.99m, IsRecommended = false, Make = "logitech", Description = "Wireless", ImageUrl = "\\Images\\Catalog\\Logitech Keyboard.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Logitech Keyboard.jpg",  CategoryId = 2 },
                    new Item { ItemId = 9, Name = "Bose Headphones", Price = 89.99m, IsRecommended = false, Make = "bose", Description = "Over-Ear Wireless Headphones", ImageUrl = "\\Images\\Catalog\\Bose Headphones.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Bose Headphones.jpg",  CategoryId = 4 },
                    new Item { ItemId = 10, Name = "Razer Gaming Keyboard", Price = 34.99m, IsRecommended = false, Make = "razer", Description = "Huntsman Tournament Edition", ImageUrl = "\\Images\\Catalog\\Razer Gaming Keyboard.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Razer Gaming Keyboard.jpg", CategoryId = 2 },
                    new Item { ItemId = 11, Name = "LG Curved Monitor", Price = 389.99m, IsRecommended = true, Make = "lg", Description = "Curved UltraWide, 3440x1440, Borderless Display", ImageUrl = "\\Images\\Catalog\\LG Curved Monitor.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\LG Curved Monitor.jpg",  CategoryId = 1 },
                    new Item { ItemId = 12, Name = "Asus Curved Gaming Monitor", Price = 207.00m, IsRecommended = false, Make = "asus", Description = "Curved Gaming Monitor, 144Hz, Black", ImageUrl = "\\Images\\Catalog\\Asus Curved Gaming Monitor.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\Asus Curved Gaming Monitor.jpg", CategoryId = 1 },
                    new Item { ItemId = 13, Name = "HP LaserJet Printer", Price = 240.00m, IsRecommended = false, Make = "hp", Description = "Multifunction Wireless Laser Printer, White", ImageUrl = "\\Images\\Catalog\\HP LaserJet Printer.jpg", ImageThumbnailUrl = "\\Images\\Catalog\\HP LaserJet Printer.jpg", CategoryId = 5 }
                 

);


        }
    }
}
