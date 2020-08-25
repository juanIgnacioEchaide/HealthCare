using HealthCare.API.Interfaces;
using HealthCare.API.Repositories;

namespace HealthCare.API.Data
{
    public class UnitOfWork  : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(
            DataContext context,
            IPatientRepository patientRepository,
            ITechnicianRepository technicianRepository,
            IPhysicianRepository physicianRepository,
            IMedicalRecordRepository medicalRecordRepository,
            IMedicalRegistryRepository medicalRegistryRepository,
            IHealthCareProviderRepository healthCareProviderRepository
            )
        {
        _context = context; 
        this.PatientRepository = patientRepository;
        this.PhysicianRepository = physicianRepository;
        this.TechnicianRepository = technicianRepository;
        this.MedicalRecordRepository = medicalRecordRepository;
        this.MedicalRegistryRepository = medicalRegistryRepository;
        this.HealthCareProviderRepository = healthCareProviderRepository;
        }


        public IPatientRepository PatientRepository { get; internal set;}
        public ITechnicianRepository TechnicianRepository {get; internal set;}
        public IPhysicianRepository PhysicianRepository {get; internal set;}
        public IMedicalRecordRepository MedicalRecordRepository { get; internal set; }
        public IMedicalRegistryRepository MedicalRegistryRepository { get; internal set; }
        public IHealthCareProviderRepository HealthCareProviderRepository { get; internal set; }


        public int Commit()
        {
           return this._context.SaveChanges();
        }

        public void DetectChanges()
        {
            this._context.ChangeTracker.DetectChanges();
        }

        public void Rollback()
        {
            _context.Dispose();
        }

     }
}