using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prod_Avail",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Prod_Amount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prod_Amount",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "Prod_Avail",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
