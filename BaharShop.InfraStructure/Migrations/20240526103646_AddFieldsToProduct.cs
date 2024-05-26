using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaharShop.InfraStructure.Migrations
{
    public partial class AddFieldsToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Inventory",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Product",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category",
                column: "ParentId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Inventory",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Product");
        }
    }
}
