using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    public partial class food_price_to_food_store_price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Foods");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "FoodStores",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "FoodStores");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Foods",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
