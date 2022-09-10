using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class Add_equipment_and_offers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
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
                    ZavrsetakRadova = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    DatumKupnje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NabavnaCijena = table.Column<Double>(type: "float", nullable: false),
                    CijenaDostave = table.Column<Double>(type: "float", nullable: false),
                    Proizvodac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dobavljac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferentnaCijena = table.Column<Double>(type: "float", defaultValue:0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                }); ; ;

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");
            migrationBuilder.DropTable(
                name: "Equipment");
        }

    }
}