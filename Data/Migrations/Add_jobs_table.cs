using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class Add_jobs_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpisPosla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojOsoba = table.Column<int>(type: "int", nullable: false),
                    BrojSati = table.Column<int>(type: "int", nullable: false),
                    CijenaSata = table.Column<int>(type: "int", nullable: false),
                    PotrebnaOprema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PocetakRadova = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZavrsetakRadova = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trosak = table.Column<Double>(type: "float", nullable: false),
                    Profit = table.Column<Double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO Jobs ( Naziv, OpisPosla, BrojOsoba, BrojSati, CijenaSata, PotrebnaOprema, PocetakRadova, ZavrsetakRadova, Trosak, Profit) " +
                "VALUES ('Prodaja opreme za Q1', 'Prodaja opreme za prvi kvartal', '10', '720', '5', '/', '2022-01-01T08:00:00.000000', '2022-03-31T16:00:00.000000', '36000', '152950.14');", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
