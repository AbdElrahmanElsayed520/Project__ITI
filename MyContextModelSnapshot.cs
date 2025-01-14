﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJECTITI.Context;

#nullable disable

namespace PROJECTITI.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PROJECTITI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The iPhone was the first mobile phone to use multi-touch technology. Since the iPhone's launch, it has gained larger screen sizes, video-recording, waterproofing, and many accessibility features.",
                            Name = "Iphone"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Personalized Spatial Audio that places sound all around you, as well as longer battery life",
                            Name = "AirPods"
                        });
                });

            modelBuilder.Entity("PROJECTITI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Storage=128G 	 Ram=6G",
                            ImagePath = "C:\\Users\\bodye\\Desktop\\New folder (5)\\apple-iphone-128gb-4gb-5g-midnight_1.jpg",
                            Quantity = 4,
                            Title = "Iphone 13"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Storage=128G 	 Ram=8G",
                            ImagePath = "C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg",
                            Quantity = 5,
                            Title = "Iphone 14"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Storage=128G 	 Ram=8G",
                            ImagePath = "C:\\Users\\bodye\\Desktop\\New folder (5)\\ma762-1_1.jpg",
                            Quantity = 6,
                            Title = "Iphone 15"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Designed specifically for you\r\n\r\nNow you can quickly charge your AirPods through the wireless charging case.\r\nAlso, the charging case will enable you to listen to songs for more than 24 hours continuously and talk for more than 18 hours.\r\nDo you need fast shipping? All you have to do is put the AirPods in the box for 15 minutes to enjoy up to 3 hours of songs and music clips and 2 hours of talk time.\r\nIn addition to the ability to charge the AirPods easily through the Lightning port",
                            ImagePath = "C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg",
                            Quantity = 2,
                            Title = "AirPods 2"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "AirPods (3rd generation) feature Spatial Audio that places sound all around you, Adaptive EQ that tunes music to your ears, and longer battery life",
                            ImagePath = "C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg",
                            Quantity = 7,
                            Title = "AirPods 3"
                        });
                });

            modelBuilder.Entity("PROJECTITI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alimohamed@gmail.com",
                            FirstName = "Ali",
                            LastName = "mohamed",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ahmedosama@gmail.com",
                            FirstName = "Ahmed",
                            LastName = "Osama",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 3,
                            Email = "abdoelsayed@gmail.com",
                            FirstName = "Abdo",
                            LastName = "Elsayed",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 4,
                            Email = "essammostafa@gmail.com",
                            FirstName = "Essam",
                            LastName = "Mostafa",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("PROJECTITI.Models.Product", b =>
                {
                    b.HasOne("PROJECTITI.Models.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("PROJECTITI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
