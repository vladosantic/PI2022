using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class Add_equipment_and_offerscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
               name: "CijenaReferentneOpreme",
               table: "Equipment",
               type: "float",
               nullable: true);


            migrationBuilder.AddColumn<string>(
              name: "NazivReferentneOpreme",
              table: "Equipment",
              type: "nvarchar(max)",
              nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "CijenaReferentneOpreme",
               table: "Equipment");

            migrationBuilder.DropColumn(
               name: "NazivReferentneOpreme",
               table: "Equipment");
        }
    }
}
