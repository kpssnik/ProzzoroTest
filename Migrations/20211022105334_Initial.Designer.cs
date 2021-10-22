﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProzzoroTest.Domain;

namespace ProzzoroTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211022105334_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProzzoroTest.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ProzzoroTest.Domain.Entities.GalleryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GalleryImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alt = "First image",
                            Description = "First image",
                            ImageSource = "4.png"
                        },
                        new
                        {
                            Id = 2,
                            Alt = "Second image",
                            Description = "Second image",
                            ImageSource = "3.png"
                        },
                        new
                        {
                            Id = 3,
                            Alt = "Third image",
                            Description = "Third image",
                            ImageSource = "2.png"
                        },
                        new
                        {
                            Id = 4,
                            Alt = "Fourth image",
                            Description = "Fourth image",
                            ImageSource = "1.png"
                        });
                });

            modelBuilder.Entity("ProzzoroTest.Domain.Entities.NavigationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Href")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NavigationItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Href = "/",
                            Text = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Href = "/gallery",
                            Text = "Gallery"
                        },
                        new
                        {
                            Id = 3,
                            Href = "/contact",
                            Text = "Contact"
                        });
                });

            modelBuilder.Entity("ProzzoroTest.Domain.Entities.SkillItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SkillItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Basic C++ development using STL and Boost libraries",
                            ImageAlt = "C++",
                            ImageSource = "cpp.png"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Creating applications using C# technologies",
                            ImageAlt = ".NET C#",
                            ImageSource = "net.png"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Marking up web pages using HTML/CSS with Bootstrap",
                            ImageAlt = "HTML",
                            ImageSource = "html.png"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Experience with MSSQL Server",
                            ImageAlt = "MSSQL",
                            ImageSource = "mssql.png"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Code-First approach and Reverse Engineering using ORM Entity Framework Core",
                            ImageAlt = "EF CORE",
                            ImageSource = "efcore.png"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Creating web applications using ASP.NET Core",
                            ImageAlt = "ASP",
                            ImageSource = "asp.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
