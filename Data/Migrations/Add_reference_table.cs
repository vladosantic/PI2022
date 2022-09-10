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
