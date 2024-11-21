using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLocalPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1001, "Stationary", "Blue Pen", "D:\\.net\\Pen_image.jpg", "https://th.bing.com/th/id/R.b3a23162bff93129ae5e2a2dc5dcccba?rik=VDbD8YO8zBTEkQ&riu=http%3a%2f%2fnatpen.scene7.com%2fis%2fimage%2fNatPenVegas%2fLNS&ehk=weqJ63x%2fGhajxjBeBcMzyfFeNWN1PBWyFGqhU6D78%2bo%3d&risl=&pid=ImgRaw&r=0", "Pen", 10.0 },
                    { 1002, "Stationary", "C3 Pro", "D:\\.net\\Phone_image.webp", "https://images.thequint.com/thequint/2020-02/9e5ba4c9-6a9b-441d-80de-a02a28228182/Realme_C3_1024.webp?rect=0%2C38%2C1024%2C538&w=1200&auto=format%2Ccompress&ogImage=true", "Redmi Phone", 25000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
