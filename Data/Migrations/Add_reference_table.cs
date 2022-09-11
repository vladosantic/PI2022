using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class ReferencesController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dobavljac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CijenaReferentneOpreme = table.Column<Double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                });
            migrationBuilder.AddColumn<int>(
               name: "EquipmentId",
               table: "References",
               type: "int",
               nullable: true);
            migrationBuilder.CreateIndex(
               name: "IX_References_EquipmentId",
               table: "References",
               column: "EquipmentId");
            migrationBuilder.AddForeignKey(
                name: "FK_References_Equipment_EquipmentId",
                table: "References",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id");

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Majica','Ljetna kolekcija','Nike majica kratkih rukava', 'Nike Import', '50');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Dres','Proljetna kolekcija','Dres kratkih rukava bez oznaka', 'Adidas Import', '80');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Jakna','Zimska kolekcija','Zimska jakna', 'Sport Import', '120');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Ruksak','Jesenska kolekcija','Ruksak za trening', 'Nike Import', '60');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Majica','Ljetna kolekcija','Nike majica kratkih rukava', 'Nike Import', '50');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Reket za tenis','Ostalo','Reket za tenis 45 cm', 'Tenis Import', '160');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Lopta za nogomet','Ostalo','Lopta za nogomet na travi', 'Adidas Import', '80');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Lopta za rukomet','Ostalo','Lopta za rukomet', 'Hummel Import', '75');", false);

            migrationBuilder.Sql("INSERT INTO [References] ( Naziv, Kategorija, Opis, Dobavljac, CijenaReferentneOpreme) " +
                "VALUES ('Kaciga','Ostalo','Kaciga za bicikl ili rolanje', 'Sport Import', '50');", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_Equipment_EquipmentId",
                table: "References");
            migrationBuilder.DropTable(
                name: "References");
            migrationBuilder.DropIndex(
                name: "IX_References_EquipmentId",
                table: "References");
        }
    }
}
