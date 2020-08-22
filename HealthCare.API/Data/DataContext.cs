using System;
using HealthCare.API.Model;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){ }
        public DbSet<Patient> Patients {get; set;}
        public DbSet<Physician> Physicians {get; set;}
        public DbSet<Technician> Technicians {get; set;}
        public DbSet<HealthCareProvider> HealthCareProviders {get; set;}
        public DbSet<MedicalRecord> MedicalRecords {get; set;}   
        public DbSet<MedicalRegistry> MedicalRegistries {get; set;}
        public DbSet<PatientPhysician> PatientPhysicians {get; set;}
        public DbSet<PatientTechnician> PatientTechnicians {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Patient Physician Many To Many Relationship
            builder.Entity<PatientPhysician>()
                .HasKey(pp => new { pp.PatientId, pp.PhysicianId });  
            builder.Entity<PatientPhysician>()
                .HasOne(pp => pp.Physician)
                .WithMany(pp => pp.Patients)
                .HasForeignKey(pp => pp.PatientId);  
            builder.Entity<PatientPhysician>()
                .HasOne(pp => pp.Patient)
                .WithMany(pp => pp.physicians)
                .HasForeignKey(pp => pp.PhysicianId);   

            //Patient Technician Many To Many Relationship   
            builder.Entity<PatientTechnician>()
                .HasKey(pp => new { pp.PatientId, pp.TechnicianId });  
            builder.Entity<PatientTechnician>()
                .HasOne(pp => pp.Technician)
                .WithMany(pp => pp.Patients)
                .HasForeignKey(pp => pp.PatientId);  
            builder.Entity<PatientTechnician>()
                .HasOne(pp => pp.Patient)
                .WithMany(pp => pp.technicians)
                .HasForeignKey(pp => pp.TechnicianId);      
        }
       
    }
}