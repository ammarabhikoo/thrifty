using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi_website.Migrations
{
    public partial class addedproductscolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Purchases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        
    }
}
