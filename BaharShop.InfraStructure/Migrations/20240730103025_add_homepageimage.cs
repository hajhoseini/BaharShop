using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaharShop.InfraStructure.Migrations
{
    public partial class add_homepageimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Province",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Product",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "OrderItem",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Order",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Customer",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Comment",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "City",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Category",
                newName: "InsertDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Address",
                newName: "InsertDate");

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Province",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Province",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Province",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "OrderItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "OrderItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "OrderItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Comment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Comment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Comment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "City",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "City",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "City",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Address",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveDate",
                table: "Address",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Address",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeature_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Src = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "InsertDate", "IsRemoved", "Name", "RemoveDate", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 7, 30, 14, 0, 25, 423, DateTimeKind.Local).AddTicks(6516), false, "Admin", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "InsertDate", "IsRemoved", "Name", "RemoveDate", "UpdateDate" },
                values: new object[] { 2, new DateTime(2024, 7, 30, 14, 0, 25, 423, DateTimeKind.Local).AddTicks(6625), false, "Operator", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "InsertDate", "IsRemoved", "Name", "RemoveDate", "UpdateDate" },
                values: new object[] { 3, new DateTime(2024, 7, 30, 14, 0, 25, 423, DateTimeKind.Local).AddTicks(6642), false, "Customer", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeature_ProductId",
                table: "ProductFeature",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "ProductFeature");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "City");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "City");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "RemoveDate",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Province",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Product",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "OrderItem",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Order",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Customer",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Comment",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "City",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Category",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Address",
                newName: "CreateDate");
        }
    }
}
