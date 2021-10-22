using Microsoft.EntityFrameworkCore.Migrations;

namespace ProzzoroTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    IsValid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageSource = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Alt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavigationItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Href = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageSource = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GalleryImages",
                columns: new[] { "Id", "Alt", "Description", "ImageSource" },
                values: new object[,]
                {
                    { 1, "First image", "First image", "4.png" },
                    { 2, "Second image", "Second image", "3.png" },
                    { 3, "Third image", "Third image", "2.png" },
                    { 4, "Fourth image", "Fourth image", "1.png" }
                });

            migrationBuilder.InsertData(
                table: "NavigationItems",
                columns: new[] { "Id", "Href", "Text" },
                values: new object[,]
                {
                    { 1, "/", "Home" },
                    { 2, "/gallery", "Gallery" },
                    { 3, "/contact", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "SkillItems",
                columns: new[] { "Id", "Description", "ImageAlt", "ImageSource" },
                values: new object[,]
                {
                    { 1, "Basic C++ development using STL and Boost libraries", "C++", "cpp.png" },
                    { 2, "Creating applications using C# technologies", ".NET C#", "net.png" },
                    { 3, "Marking up web pages using HTML/CSS with Bootstrap", "HTML", "html.png" },
                    { 4, "Experience with MSSQL Server", "MSSQL", "mssql.png" },
                    { 5, "Code-First approach and Reverse Engineering using ORM Entity Framework Core", "EF CORE", "efcore.png" },
                    { 6, "Creating web applications using ASP.NET Core", "ASP", "asp.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "GalleryImages");

            migrationBuilder.DropTable(
                name: "NavigationItems");

            migrationBuilder.DropTable(
                name: "SkillItems");
        }
    }
}
