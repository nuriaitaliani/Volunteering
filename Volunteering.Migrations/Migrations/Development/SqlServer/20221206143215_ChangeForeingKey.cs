using Microsoft.EntityFrameworkCore.Migrations;

namespace Volunteering.Migrations.Migrations.Development.SqlServer
{
    public partial class ChangeForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sch_act",
                table: "schedule");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_activity_id",
                table: "schedule",
                column: "activity_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sch_act",
                table: "schedule",
                column: "activity_id",
                principalTable: "activity",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sch_act",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_activity_id",
                table: "schedule");

            migrationBuilder.AddForeignKey(
                name: "fk_sch_act",
                table: "schedule",
                column: "id",
                principalTable: "activity",
                principalColumn: "id");
        }
    }
}
