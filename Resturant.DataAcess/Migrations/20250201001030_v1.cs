using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Cat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Cat_Id);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    U_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => new { x.U_Id, x.Prod_Id });
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prod_Price = table.Column<int>(type: "int", nullable: false),
                    Prod_Avail = table.Column<bool>(type: "bit", nullable: false),
                    Cat_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Prod_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_BirthDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
