﻿// <auto-generated />
using System;
using HealthCare.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthCare.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("HealthCare.API.Model.HealthCareProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("MedicalPlan")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HealthCareProviders");
                });

            modelBuilder.Entity("HealthCare.API.Model.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("HealthCare.API.Model.MedicalRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HealthCareProviderId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PhysicianId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TechnicianId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HealthCareProviderId");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PhysicianId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("MedicalRegistries");
                });

            modelBuilder.Entity("HealthCare.API.Model.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CurrentHCProviderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("HCCredentialNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("SocialSecurityNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CurrentHCProviderId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HealthCare.API.Model.PatientPhysician", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhysicianId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PatientId", "PhysicianId");

                    b.HasIndex("PhysicianId");

                    b.ToTable("PatientPhysicians");
                });

            modelBuilder.Entity("HealthCare.API.Model.PatientTechnician", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TechnicianId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PatientId", "TechnicianId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("PatientTechnicians");
                });

            modelBuilder.Entity("HealthCare.API.Model.Physician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("LegalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("License")
                        .HasColumnType("TEXT");

                    b.Property<int>("SocialSecurityNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Specialty")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Physicians");
                });

            modelBuilder.Entity("HealthCare.API.Model.Technician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("LegalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("License")
                        .HasColumnType("TEXT");

                    b.Property<int>("SocialSecurityNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Specialty")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Technicians");
                });

            modelBuilder.Entity("HealthCare.API.Model.MedicalRecord", b =>
                {
                    b.HasOne("HealthCare.API.Model.Patient", null)
                        .WithOne("MedicalRecord")
                        .HasForeignKey("HealthCare.API.Model.MedicalRecord", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthCare.API.Model.MedicalRegistry", b =>
                {
                    b.HasOne("HealthCare.API.Model.HealthCareProvider", "HealthCareProvider")
                        .WithMany()
                        .HasForeignKey("HealthCareProviderId");

                    b.HasOne("HealthCare.API.Model.MedicalRecord", null)
                        .WithMany("MedicalRegistries")
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("HealthCare.API.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("HealthCare.API.Model.Physician", "Physician")
                        .WithMany()
                        .HasForeignKey("PhysicianId");

                    b.HasOne("HealthCare.API.Model.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId");
                });

            modelBuilder.Entity("HealthCare.API.Model.Patient", b =>
                {
                    b.HasOne("HealthCare.API.Model.HealthCareProvider", "CurrentHCProvider")
                        .WithMany()
                        .HasForeignKey("CurrentHCProviderId");
                });

            modelBuilder.Entity("HealthCare.API.Model.PatientPhysician", b =>
                {
                    b.HasOne("HealthCare.API.Model.Physician", "Physician")
                        .WithMany("Patients")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthCare.API.Model.Patient", "Patient")
                        .WithMany("physicians")
                        .HasForeignKey("PhysicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthCare.API.Model.PatientTechnician", b =>
                {
                    b.HasOne("HealthCare.API.Model.Technician", "Technician")
                        .WithMany("Patients")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthCare.API.Model.Patient", "Patient")
                        .WithMany("technicians")
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
