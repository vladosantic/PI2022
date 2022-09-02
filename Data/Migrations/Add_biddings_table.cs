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
                    NazivNatječaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpisPosla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcijenjenaVrijednostPosla = table.Column<int>(type: "int", nullable: false),
                    TrajanjeNatjecaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Objavljen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DobitnikNatječaja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProlaznostNatječaja = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidding", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bidding");
        }
    }
}
