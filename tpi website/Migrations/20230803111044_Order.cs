using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi_website.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Ship_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To_street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To_zip = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
