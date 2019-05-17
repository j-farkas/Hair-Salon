using Microsoft.EntityFrameworkCore.Migrations;

namespace hair_salon.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(nullable: true),
                    stylist = table.Column<int>(nullable: false),
                    hair = table.Column<int>(nullable: false),
                    haircut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "join",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    scissors_id = table.Column<int>(nullable: false),
                    client_id = table.Column<int>(nullable: false),
                    stylist_id = table.Column<int>(nullable: false),
                    prefix_id = table.Column<int>(nullable: false),
                    suffix_id = table.Column<int>(nullable: false),
                    specialty_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_join", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prefix",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(nullable: true),
                    max_value = table.Column<int>(nullable: false),
                    min_value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prefix", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scissors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(nullable: true),
                    prefix_1 = table.Column<int>(nullable: false),
                    prefix_1_value = table.Column<int>(nullable: false),
                    prefix_2 = table.Column<int>(nullable: false),
                    prefix_2_value = table.Column<int>(nullable: false),
                    suffix_1 = table.Column<int>(nullable: false),
                    suffix_1_value = table.Column<int>(nullable: false),
                    suffix_2 = table.Column<int>(nullable: false),
                    suffix_2_value = table.Column<int>(nullable: false),
                    quality = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scissors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "specialty",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialty", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stylist",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    hair = table.Column<int>(nullable: false),
                    scissors = table.Column<int>(nullable: false),
                    drop = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stylist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "suffix",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(nullable: true),
                    max_value = table.Column<int>(nullable: false),
                    min_value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suffix", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "join");

            migrationBuilder.DropTable(
                name: "prefix");

            migrationBuilder.DropTable(
                name: "scissors");

            migrationBuilder.DropTable(
                name: "specialty");

            migrationBuilder.DropTable(
                name: "stylist");

            migrationBuilder.DropTable(
                name: "suffix");
        }
    }
}
