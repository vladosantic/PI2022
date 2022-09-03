using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PI2022.Data.Migrations
{
    public partial class Add_schedule_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Jobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zaposlenik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PocetakRada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZavrsetakRada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojSati = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ScheduleId",
                table: "Jobs",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ScheduleId",
                table: "Employees",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Schedule_ScheduleId",
                table: "Employees",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Schedule_ScheduleId",
                table: "Jobs",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Schedule_ScheduleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Schedule_ScheduleId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_ScheduleId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ScheduleId",
                table: "Employees");
        }
    }
}
