using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi_website.Migrations
{
    public partial class ordersfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ordersfixed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To_street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To_zip = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordersfixed", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ordersfixed");
        }
    }
}
