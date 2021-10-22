using Microsoft.EntityFrameworkCore.Migrations;

namespace ProzzoroTest.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageSource",
                value: "4.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageSource",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageSource",
                value: "2.jpg");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageSource",
                value: "1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageSource",
                value: "4.png");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageSource",
                value: "3.png");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageSource",
                value: "2.png");

            migrationBuilder.UpdateData(
                table: "GalleryImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageSource",
                value: "1.png");
        }
    }
}
