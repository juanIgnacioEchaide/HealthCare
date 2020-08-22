using System;
using HealthCare.API.Repositories;

namespace HealthCare.API.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository PatientRepository {get;}
        TechnicianRepository TechnicianRepository {get;}
        PhysicianRepository PhysicianRepository {get;}
        int Commit();
        void DetectChanges();
        void Rollback();
    }
}