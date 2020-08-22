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
            IPhysicianRepository physicianRepository
            )
        {
        _context = context; 
        this.PatientRepository = patientRepository;
        this.TechnicianRepository = technicianRepository;
        this.PhysicianRepository = physicianRepository;
        }


        public IPatientRepository PatientRepository { get; internal set;}
        public ITechnicianRepository TechnicianRepository {get; internal set;}
        public IPhysicianRepository PhysicianRepository {get; internal set;}

        TechnicianRepository IUnitOfWork.TechnicianRepository => throw new System.NotImplementedException();

        PhysicianRepository IUnitOfWork.PhysicianRepository => throw new System.NotImplementedException();

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