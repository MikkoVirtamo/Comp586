using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "MoviesList",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    Movies = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesList", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    fKeyID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.user);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MoviesList");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
