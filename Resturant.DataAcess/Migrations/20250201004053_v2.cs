using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_Cat_Id",
                table: "Products",
                column: "Cat_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_Prod_Id",
                table: "Favorites",
                column: "Prod_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Products_Prod_Id",
                table: "Favorites",
                column: "Prod_Id",
                principalTable: "Products",
                principalColumn: "Prod_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Users_U_Id",
                table: "Favorites",
                column: "U_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Cat_Id",
                table: "Products",
                column: "Cat_Id",
                principalTable: "Categories",
                principalColumn: "Cat_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Products_Prod_Id",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Users_U_Id",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Cat_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Cat_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_Prod_Id",
                table: "Favorites");
        }
    }
}
