using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesWebSite.Migrations
{
    /// <inheritdoc />
    public partial class geneldetay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenelDetay",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenelDetay",
                table: "Movies");
        }
    }
}
