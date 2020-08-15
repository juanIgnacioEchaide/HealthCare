using System;

namespace HealthCare.API.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IPatientRepository PatientRepository {get;};
        ITechnicianRepository TechnicianRepository {get;}
        IPhysicianRepository PhysicianRepository {get;}
        void Commit();
        void Rollback();
        void DetectChanges();
    }
}