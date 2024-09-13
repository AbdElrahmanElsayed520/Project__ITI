using Microsoft.EntityFrameworkCore;
using PROJECTITI.Models;

namespace PROJECTITI.Context
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=Project_ITI;Trusted_Connection=True;Encrypt=false");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var users = new List<User>
            {
                new User{Id=1,FirstName="Ali",LastName="mohamed",Email="alimohamed@gmail.com",Password="1234"},
                new User{Id=2,FirstName="Ahmed",LastName="Osama",Email="ahmedosama@gmail.com",Password="1234"},
                new User{Id=3,FirstName="Abdo",LastName="Elsayed",Email="abdoelsayed@gmail.com",Password="1234"},
                new User{Id=4,FirstName="Essam",LastName="Mostafa",Email="essammostafa@gmail.com",Password="1234"},

            };

            var products = new List<Product> {

            new Product{Id=1,Title="Iphone 13",Description="Storage=128G \t Ram=6G",Quantity=4,CategoryId=1,ImagePath="C:\\Users\\bodye\\Desktop\\New folder (5)\\apple-iphone-128gb-4gb-5g-midnight_1.jpg"},
            new Product{Id=2,Title="Iphone 14",Description="Storage=128G \t Ram=8G",Quantity=5,CategoryId=1,ImagePath="C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg"},
            new Product{Id=3,Title="Iphone 15",Description="Storage=128G \t Ram=8G",Quantity=6, CategoryId = 1,ImagePath="C:\\Users\\bodye\\Desktop\\New folder (5)\\ma762-1_1.jpg"},
            new Product{Id=4,Title="AirPods 2",Description="Designed specifically for you\r\n\r\nNow you can quickly charge your AirPods through the wireless charging case.\r\nAlso, the charging case will enable you to listen to songs for more than 24 hours continuously and talk for more than 18 hours.\r\nDo you need fast shipping? All you have to do is put the AirPods in the box for 15 minutes to enjoy up to 3 hours of songs and music clips and 2 hours of talk time.\r\nIn addition to the ability to charge the AirPods easily through the Lightning port",Quantity=2,CategoryId=2,ImagePath="C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg"},
            new Product{Id=5,Title="AirPods 3",Description="AirPods (3rd generation) feature Spatial Audio that places sound all around you, Adaptive EQ that tunes music to your ears, and longer battery life",Quantity=7,CategoryId=2,ImagePath="C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg"},

            };

            var categories = new List<Category> {

            new Category{Id=1,Name="Iphone",Description="The iPhone was the first mobile phone to use multi-touch technology. Since the iPhone's launch, it has gained larger screen sizes, video-recording, waterproofing, and many accessibility features."},
            new Category{Id=2,Name="AirPods",Description="Personalized Spatial Audio that places sound all around you, as well as longer battery life"}


            };
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }
}
