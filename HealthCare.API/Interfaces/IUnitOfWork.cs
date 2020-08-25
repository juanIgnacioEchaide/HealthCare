using System;
using HealthCare.API.Repositories;

namespace HealthCare.API.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository PatientRepository {get;}
        IPhysicianRepository PhysicianRepository {get;}
        ITechnicianRepository TechnicianRepository { get;}
        IMedicalRecordRepository MedicalRecordRepository { get; }
        IMedicalRegistryRepository MedicalRegistryRepository { get;}



        int Commit();
        void DetectChanges();
        void Rollback();
    }
}