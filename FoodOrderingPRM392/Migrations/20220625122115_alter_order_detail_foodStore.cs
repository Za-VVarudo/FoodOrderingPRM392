using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingPRM392.Migrations
{
    public partial class alter_order_detail_foodStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Foods_FoodId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodStores",
                table: "FoodStores");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<long>(
                name: "StoreId",
                table: "Orders",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<Guid>(
                name: "FoodStoreId",
                table: "OrderDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "FoodStores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "FoodStoreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodStores",
                table: "FoodStores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_FoodStoreId",
                table: "OrderDetails",
                column: "FoodStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStores_StoreId_FoodId",
                table: "FoodStores",
                columns: new[] { "StoreId", "FoodId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_FoodStores_FoodStoreId",
                table: "OrderDetails",
                column: "FoodStoreId",
                principalTable: "FoodStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_FoodStores_FoodStoreId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_FoodStoreId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodStores",
                table: "FoodStores");

            migrationBuilder.DropIndex(
                name: "IX_FoodStores_StoreId_FoodId",
                table: "FoodStores");

            migrationBuilder.DropColumn(
                name: "FoodStoreId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FoodStores");

            migrationBuilder.AlterColumn<long>(
                name: "StoreId",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FoodId",
                table: "OrderDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "FoodId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodStores",
                table: "FoodStores",
                columns: new[] { "StoreId", "FoodId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_FoodId",
                table: "OrderDetails",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Foods_FoodId",
                table: "OrderDetails",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
