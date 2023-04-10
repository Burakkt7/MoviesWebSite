using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesWebSite.Migrations
{
    /// <inheritdoc />
    public partial class favoritetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieCatagories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieYazar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieIMDB = table.Column<float>(type: "real", nullable: false),
                    Hakkında = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenelDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
