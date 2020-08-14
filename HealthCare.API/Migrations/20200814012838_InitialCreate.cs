using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCare.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthCareProviders",
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
                    table.PrimaryKey("PK_HealthCareProviders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Physicians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LegalId = table.Column<int>(nullable: false),
                    SocialSecurityNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LegalId = table.Column<int>(nullable: false),
                    SocialSecurityNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SocialSecurityNumber = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CurrentHCProviderId = table.Column<int>(nullable: true),
                    HCCredentialNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_HealthCareProviders_CurrentHCProviderId",
                        column: x => x.CurrentHCProviderId,
                        principalTable: "HealthCareProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientPhysicians",
                columns: table => new
                {
                    PhysicianId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPhysicians", x => new { x.PatientId, x.PhysicianId });
                    table.ForeignKey(
                        name: "FK_PatientPhysicians_Physicians_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Physicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientPhysicians_Patients_PhysicianId",
                        column: x => x.PhysicianId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientTechnicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTechnicians", x => new { x.PatientId, x.TechnicianId });
                    table.ForeignKey(
                        name: "FK_PatientTechnicians_Technicians_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Technicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientTechnicians_Patients_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRegistries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(nullable: true),
                    HealthCareProviderId = table.Column<int>(nullable: true),
                    PhysicianId = table.Column<int>(nullable: true),
                    TechnicianId = table.Column<int>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    MedicalRecordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRegistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRegistries_HealthCareProviders_HealthCareProviderId",
                        column: x => x.HealthCareProviderId,
                        principalTable: "HealthCareProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistries_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistries_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistries_Physicians_PhysicianId",
                        column: x => x.PhysicianId,
                        principalTable: "Physicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRegistries_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistries_HealthCareProviderId",
                table: "MedicalRegistries",
                column: "HealthCareProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistries_MedicalRecordId",
                table: "MedicalRegistries",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistries_PatientId",
                table: "MedicalRegistries",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistries_PhysicianId",
                table: "MedicalRegistries",
                column: "PhysicianId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRegistries_TechnicianId",
                table: "MedicalRegistries",
                column: "TechnicianId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPhysicians_PhysicianId",
                table: "PatientPhysicians",
                column: "PhysicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CurrentHCProviderId",
                table: "Patients",
                column: "CurrentHCProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTechnicians_TechnicianId",
                table: "PatientTechnicians",
                column: "TechnicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalRegistries");

            migrationBuilder.DropTable(
                name: "PatientPhysicians");

            migrationBuilder.DropTable(
                name: "PatientTechnicians");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Physicians");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "HealthCareProviders");
        }
    }
}
