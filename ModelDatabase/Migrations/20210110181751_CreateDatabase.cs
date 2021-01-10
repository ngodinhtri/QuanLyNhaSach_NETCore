using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDatabase.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Quanity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Price = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BillItem",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BillID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0"),
                    Quanity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_billItem_Bill",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_billItem_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CustomerID",
                table: "Bill",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItem_BillID",
                table: "BillItem",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItem_ProductID",
                table: "BillItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Name",
                table: "Product",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_UserName",
                table: "UserAccount",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillItem");

            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
