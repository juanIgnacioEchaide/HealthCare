using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCare.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "healthCareProviders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MedicalPlan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthCareProviders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "physicians",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    License = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_physicians", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrentHCProviderId = table.Column<int>(nullable: true),
                    HCCredentialNumber = table.Column<int>(nullable: false),
                    PhysicianID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_patients_healthCareProviders_CurrentHCProviderId",
                        column: x => x.CurrentHCProviderId,
                        principalTable: "healthCareProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_patients_physicians_PhysicianID",
                        column: x => x.PhysicianID,
                        principalTable: "physicians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "medicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalRecords_patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "patients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRegistry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientID = table.Column<int>(nullable: true),
                    HealthCareProviderId = table.Column<int>(nullable: true),
                    PhysicianID = table.Column<long>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    MedicalRecordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRegistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRegistry_healthCareProviders_HealthCareProviderId",
                        column: x => x.HealthCareProviderId,
                        principalTable: "healthCareProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistry_medicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "medicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistry_patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "patients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistry_physicians_PhysicianID",
                        column: x => x.PhysicianID,
                        principalTable: "physicians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_medicalRecords_PatientId",
                table: "medicalRecords",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistry_HealthCareProviderId",
                table: "MedicalRegistry",
                column: "HealthCareProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistry_MedicalRecordId",
                table: "MedicalRegistry",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistry_PatientID",
                table: "MedicalRegistry",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistry_PhysicianID",
                table: "MedicalRegistry",
                column: "PhysicianID");

            migrationBuilder.CreateIndex(
                name: "IX_patients_CurrentHCProviderId",
                table: "patients",
                column: "CurrentHCProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_patients_PhysicianID",
                table: "patients",
                column: "PhysicianID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalRegistry");

            migrationBuilder.DropTable(
                name: "medicalRecords");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "healthCareProviders");

            migrationBuilder.DropTable(
                name: "physicians");
        }
    }
}
