using Microsoft.EntityFrameworkCore.Migrations;

namespace dreviny.Data.Migrations
{
    public partial class Druhy_Pokus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drevina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vzrust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vysadba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stanoviste = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sprasnost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odolnost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rez = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hnojeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kveteni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sklizeň = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zazimovani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruzne = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drevina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Odruda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazevOdrudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DruhStromu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vzrust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odolnost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kveteni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sklizeň = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruzne = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odruda", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drevina");

            migrationBuilder.DropTable(
                name: "Odruda");
        }
    }
}
