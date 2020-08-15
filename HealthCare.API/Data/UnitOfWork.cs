using HealthCare.API.Interfaces;
using HealthCare.API.Repositories;

namespace HealthCare.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private IPatientRepository _patientRepository {get;};
        private ITechnicianRepository _technicianRepository {get;}
        private IPhysicianRepository _physicianRepository {get;}

        public UnitOfWork(DataContext context,PatientRepository PatientRepository)
        {
         _context = context;   
        }

        public IPatientRepository PatientRepository 
        {
            get { return _patientRepository = _patientRepository ??
                 new PatientRepository(_context);
                }
        } 

        public ITechnicianRepository TechnicianRepository 
        {
            get { return _technicianRepository = _technicianRepository ??
                 new TechnicianRepository(_context);
                }
        } 
        
        public IPhysicianRepository PhysicianRepository 
        {
            get { return _physicianRepository = _physicianRepository ??
                 new PhysicianRepository(_context);
                }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void DetectChanges()
        {
            _context.DetectChanges();
        }

        public void Rollback()
        {
            _context.Dispose();
        }
    }
}