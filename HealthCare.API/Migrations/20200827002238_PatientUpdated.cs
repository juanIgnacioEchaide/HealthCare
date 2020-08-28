using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCare.API.Migrations
{
    public partial class PatientUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_HealthCareProviders_CurrentHCProviderId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_CurrentHCProviderId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CurrentHCProviderId",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "HealthCareProviderId",
                table: "Patients",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthCareProviderId",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "CurrentHCProviderId",
                table: "Patients",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CurrentHCProviderId",
                table: "Patients",
                column: "CurrentHCProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_HealthCareProviders_CurrentHCProviderId",
                table: "Patients",
                column: "CurrentHCProviderId",
                principalTable: "HealthCareProviders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
