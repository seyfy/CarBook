using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Banners_BannerID",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_BannerID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BannerID",
                table: "Cars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannerID",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BannerID",
                table: "Cars",
                column: "BannerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Banners_BannerID",
                table: "Cars",
                column: "BannerID",
                principalTable: "Banners",
                principalColumn: "BannerID");
        }
    }
}
