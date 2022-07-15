using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    public partial class save_temp_cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TempCartMeta",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempCartMeta",
                table: "Users");
        }
    }
}
