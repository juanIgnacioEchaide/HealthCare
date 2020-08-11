using System;
using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IMedicalRegistryRepository
    {
        
         ICollection<MedicalRegistry> getByPatientId(int patientId);
         ICollection<MedicalRegistry> getByCertainDate(int patientId,DateTime date);
         ICollection<MedicalRegistry> GetFromTo(int patientId,DateTime From, DateTime To);
         ICollection<MedicalRegistry> getByPhysicianAndPatient(int physicianId,int patientId);
         

    }
}