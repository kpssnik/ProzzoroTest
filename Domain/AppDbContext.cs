using Microsoft.EntityFrameworkCore;
using ProzzoroTest.Domain.Entities;
using ProzzoroTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<NavigationItem> NavigationItems { get; set; }
        public DbSet<SkillItem> SkillItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SkillItem[] skillItems = new SkillItem[]
            {
                new SkillItem(){
                    Id = 1,
                    Description="Basic C++ development using STL and Boost libraries",
                    ImageSource="cpp.png",
                    ImageAlt="C++"
                },
                new SkillItem()
                {
                    Id = 2,
                    Description="Creating applications using C# technologies",
                    ImageSource="net.png",
                    ImageAlt=".NET C#"
                },
                new SkillItem()
                {
                    Id = 3,
                    Description="Marking up web pages using HTML/CSS with Bootstrap",
                    ImageSource="html.png",
                    ImageAlt="HTML"
                },
                 new SkillItem()
                {
                    Id = 4,
                    Description="Experience with MSSQL Server",
                    ImageSource="mssql.png",
                    ImageAlt="MSSQL"
                },
                  new SkillItem()
                {
                    Id = 5,
                    Description="Code-First approach and Reverse Engineering using ORM Entity Framework Core",
                    ImageSource="efcore.png",
                    ImageAlt="EF CORE"
                },
                   new SkillItem()
                {
                    Id = 6,
                    Description="Creating web applications using ASP.NET Core",
                    ImageSource="asp.png",
                    ImageAlt="ASP"
                },
            };
            modelBuilder.Entity<SkillItem>().HasData(skillItems);


            NavigationItem[] navigationItems = new NavigationItem[]
            {
                new NavigationItem()
                {
                    Id = 1,
                    Href = "/",
                    Text = "Home"
                },
                new NavigationItem()
                {
                    Id = 2,
                    Href="/gallery",
                    Text = "Gallery"
                },
                new NavigationItem()
                {
                    Id = 3,
                    Href = "/contact",
                    Text = "Contact"
                }
            };
            modelBuilder.Entity<NavigationItem>().HasData(navigationItems);


            GalleryImage[] galleryImages = new GalleryImage[]
            {
                new GalleryImage()
                {
                    Id = 1,
                    Description = "First image",
                    ImageSource = "4.png",
                    Alt = "First image"
                },
                new GalleryImage()
                {
                    Id = 2,
                    Description = "Second image",
                    ImageSource = "3.png",
                    Alt = "Second image"
                },
                new GalleryImage()
                {
                    Id = 3,
                    Description = "Third image",
                    ImageSource = "2.png",
                    Alt = "Third image"
                },
                new GalleryImage()
                {
                    Id = 4,
                    Description = "Fourth image",
                    ImageSource = "1.png",
                    Alt = "Fourth image"
                }
            };
            modelBuilder.Entity<GalleryImage>().HasData(galleryImages);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.ConnectionString);
        }

    }
}
