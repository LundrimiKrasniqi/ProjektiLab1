using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudTest2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klienti",
                columns: table => new
                {
                    KlientiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Qyteti = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Shteti = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    ZipCodi = table.Column<int>(type: "int", nullable: false),
                    NumriKlientave = table.Column<int>(type: "int", nullable: false),
                    NumriTelefonit = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienti", x => x.KlientiID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klienti");
        }
    }
}
