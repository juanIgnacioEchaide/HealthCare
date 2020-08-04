using HealthCare.API.Model;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){ }
        DbSet<Patient> patients {get; set;}
        DbSet<Physician> physicians {get; set;}
        DbSet<HealthCareProvider> healthCareProviders {get; set;}
        DbSet<MedicalRecord> medicalRecords {get; set;}
    }
}