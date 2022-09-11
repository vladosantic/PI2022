using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class BiddingsController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bidding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcijenjenaVrijednost = table.Column<int>(type: "int", nullable: false),
                    Trajanje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objavljen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dobitnik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidding", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO Bidding ( Naziv, Opis, ProcijenjenaVrijednost, Trajanje, Objavljen, Dobitnik) " +
                "VALUES ('Blagajnik', 'Rad na blagajni, rad sa kupcima.', '2000', '30 dana', '2022-09-01T10:00:00.000000', ' ');", false);

            migrationBuilder.Sql("INSERT INTO Bidding ( Naziv, Opis, ProcijenjenaVrijednost, Trajanje, Objavljen, Dobitnik) " +
                "VALUES ('Nabava nove opreme', 'Nabava nove opreme iz jesenske kolekcije', '25000', '30 dana', '2022-08-01T10:00:00.000000', ' ');", false);

            migrationBuilder.Sql("INSERT INTO Bidding ( Naziv, Opis, ProcijenjenaVrijednost, Trajanje, Objavljen, Dobitnik) " +
                "VALUES ('Skladištar', 'Rad u skladištu', '1500', '90 dana', '2022-06-01T10:00:00.000000', 'Hrvoje Leko');", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bidding");
        }
    }
}
