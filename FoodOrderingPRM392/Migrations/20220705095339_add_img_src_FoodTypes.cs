using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    public partial class add_img_src_FoodTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "FoodTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "FoodTypes");
        }
    }
}
