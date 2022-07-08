using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    public partial class add_img_src : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lalitude",
                table: "Stores",
                newName: "Latitude");

            migrationBuilder.AddColumn<string>(
                name: "ImageSrc",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSrc",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Stores",
                newName: "Lalitude");
        }
    }
}
