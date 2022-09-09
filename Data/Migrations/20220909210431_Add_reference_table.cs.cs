using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class Add_reference_tablecs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "Dobavljac",
               table: "References",
               type: "nvarchar(max)",
               nullable: false,
               defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dobavljac",
                table: "References");

        }
    }
}
