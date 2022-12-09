using Microsoft.EntityFrameworkCore.Migrations;

namespace Volunteering.Migrations.Migrations.Development.SqlServer
{
    public partial class RenameConstraintNameSchedule1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Activity",
                table: "schedule");

            migrationBuilder.AddForeignKey(
                name: "fk_sch_act",
                table: "schedule",
                column: "id",
                principalTable: "activity",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sch_act",
                table: "schedule");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Activity",
                table: "schedule",
                column: "id",
                principalTable: "activity",
                principalColumn: "id");
        }
    }
}
