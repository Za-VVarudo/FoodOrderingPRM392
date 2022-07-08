using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    public partial class add_fk_food_foodtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodTypeId",
                table: "Foods",
                column: "FoodTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_FoodTypes_FoodTypeId",
                table: "Foods",
                column: "FoodTypeId",
                principalTable: "FoodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_FoodTypes_FoodTypeId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_FoodTypeId",
                table: "Foods");
        }
    }
}
