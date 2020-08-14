using HealthCare.API.Interfaces;
using HealthCare.API.Repositories;

namespace HealthCare.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private PatientRepository _patientRepository {get;}
        public UnitOfWork(DataContext context,PatientRepository PatientRepository)
        {
         _context = context;   
        _patientRepository = PatientRepository;
        }
        public void Commit()
        {
            this._context.SaveChanges();
        }

        public void DetectChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();
        }
    }
}