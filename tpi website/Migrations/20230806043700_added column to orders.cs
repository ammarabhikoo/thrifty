using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi_website.Migrations
{
    public partial class addedcolumntoorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer_name",
                table: "Order",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Order",
                newName: "Customer_name");
        }
    }
}
