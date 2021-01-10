using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDatabase.Migrations
{
    public partial class UpdatePriceInBillItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "BillItem",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "BillItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "0",
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);
        }
    }
}
