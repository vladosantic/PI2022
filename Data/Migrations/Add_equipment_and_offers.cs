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

            migrationBuilder.Sql("INSERT INTO Offers ( Naziv, OpisPosla, BrojOsoba, BrojSati, CijenaSata, PotrebnaOprema, PocetakRadova, ZavrsetakRadova ) " +
                "VALUES ('Prodaja opreme', 'Rad s kupcima, rad za blagajnom.', '1', '8', '5', '/', '2022-09-12T08:00:00.000', '2022-09-12T16:00:00.000');", false);

            migrationBuilder.Sql("INSERT INTO Offers ( Naziv, OpisPosla, BrojOsoba, BrojSati, CijenaSata, PotrebnaOprema, PocetakRadova, ZavrsetakRadova ) " +
                "VALUES ('Prijevoz opreme', 'Prijevoz opreme od mjesta nabave do poslovnice.', '1', '4', '8', 'Kombi', '2022-09-12T08:00:00.000', '2022-09-12T12:00:00.000');", false);

            migrationBuilder.Sql("INSERT INTO Offers ( Naziv, OpisPosla, BrojOsoba, BrojSati, CijenaSata, PotrebnaOprema, PocetakRadova, ZavrsetakRadova ) " +
               "VALUES ('Inventura opreme', 'Provjera stanja opreme i broja opreme.', '2', '40', '5', '/', '2022-09-12T08:00:00.000', '2022-09-16T16:00:00.000');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Majica','Ljetna kolekcija','150','2022-05-05T00:00:00.000','50','10','Nike','Nike Import','50');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Dres','Proljetna kolekcija','50','2021-02-01T00:00:00.000','75','10','Adidas','Adidas Import','80');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Jakna','Zimska kolekcija','100','2021-12-10T00:00:00.000','125','15','Puma','Sport Import','120');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Ruksak','Jesenska kolekcija','200','2020-09-01T00:00:00.000','60','5','Nike','Nike Import','60');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Reket za tenis','Ostalo','30','2022-09-01T00:00:00.000','159','10','Babolat','Tenis Import','160');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Lopta za nogomet','Ostalo','20','2022-07-25T00:00:00.000','80','4','Adidas','Adidas Import','80');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Lopta za rukomet','Ostalo','20','2022-07-25T00:00:00.000','70','4','Hummel','Hummel Import','75');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Kaciga','Ostalo','10','2022-06-19T00:00:00.000','45','5','Capriolo','Sport Import','50');", false);

            migrationBuilder.Sql("INSERT INTO Equipment ( Naziv, Kategorija, Kolicina, DatumKupnje, NabavnaCijena, CijenaDostave, Proizvodac, Dobavljac, ReferentnaCijena) " +
                "VALUES ('Kombi','Ostalo','1','2017-04-21T00:00:00.000','25000','0','Mercedes','AutoMarket','26700');", false);
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