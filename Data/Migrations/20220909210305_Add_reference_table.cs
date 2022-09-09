using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class Add_reference_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dobavljac",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "ReferentnaCijena",
                table: "Equipment",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dobavljac",
                table: "References");

            migrationBuilder.AlterColumn<double>(
                name: "ReferentnaCijena",
                table: "Equipment",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
