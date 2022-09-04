using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class EquipmentsController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpisPosla",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "PotrebanServis",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Potrosnja",
                table: "Equipment");

            migrationBuilder.RenameColumn(
                name: "Istrosenost",
                table: "Equipment",
                newName: "NazivReferentneOpreme");

            migrationBuilder.AddColumn<string>(
                name: "Napomena",
                table: "Schedule",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Trosak",
                table: "Jobs",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Profit",
                table: "Jobs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CijenaDostave",
                table: "Equipment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CijenaReferentneOpreme",
                table: "Equipment",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kategorija",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Placa",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Spol",
                table: "Employees",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ZaposlenOd",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.CreateTable(
                name: "Dashboard",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CijenaReferentneOpreme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bidding");

            migrationBuilder.DropTable(
                name: "Dashboard");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropColumn(
                name: "Napomena",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "Profit",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CijenaDostave",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "CijenaReferentneOpreme",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Kategorija",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Spol",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ZaposlenOd",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "NazivReferentneOpreme",
                table: "Equipment",
                newName: "Istrosenost");

            migrationBuilder.AddColumn<string>(
                name: "OpisPosla",
                table: "Schedule",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Trosak",
                table: "Jobs",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<bool>(
                name: "PotrebanServis",
                table: "Equipment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Potrosnja",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
