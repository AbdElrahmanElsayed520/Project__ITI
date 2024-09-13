using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PROJECTITI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The iPhone was the first mobile phone to use multi-touch technology. Since the iPhone's launch, it has gained larger screen sizes, video-recording, waterproofing, and many accessibility features.", "Iphone" },
                    { 2, "Personalized Spatial Audio that places sound all around you, as well as longer battery life", "AirPods" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "alimohamed@gmail.com", "Ali", "mohamed", "1234" },
                    { 2, "ahmedosama@gmail.com", "Ahmed", "Osama", "1234" },
                    { 3, "abdoelsayed@gmail.com", "Abdo", "Elsayed", "1234" },
                    { 4, "essammostafa@gmail.com", "Essam", "Mostafa", "1234" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Storage=128G 	 Ram=6G", "C:\\Users\\bodye\\Desktop\\New folder (5)\\apple-iphone-128gb-4gb-5g-midnight_1.jpg", 4, "Iphone 13" },
                    { 2, 1, "Storage=128G 	 Ram=8G", "C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg", 5, "Iphone 14" },
                    { 3, 1, "Storage=128G 	 Ram=8G", "C:\\Users\\bodye\\Desktop\\New folder (5)\\ma762-1_1.jpg", 6, "Iphone 15" },
                    { 4, 2, "Designed specifically for you\r\n\r\nNow you can quickly charge your AirPods through the wireless charging case.\r\nAlso, the charging case will enable you to listen to songs for more than 24 hours continuously and talk for more than 18 hours.\r\nDo you need fast shipping? All you have to do is put the AirPods in the box for 15 minutes to enjoy up to 3 hours of songs and music clips and 2 hours of talk time.\r\nIn addition to the ability to charge the AirPods easily through the Lightning port", "C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg", 2, "AirPods 2" },
                    { 5, 2, "AirPods (3rd generation) feature Spatial Audio that places sound all around you, Adaptive EQ that tunes music to your ears, and longer battery life", "C:\\Users\\bodye\\Desktop\\New folder (5)\\Apple-IPhone-14-With-FaceTime-128GB-6GB-RAM_1407_2.jpeg", 7, "AirPods 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
