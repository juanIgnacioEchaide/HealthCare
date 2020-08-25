using System;
using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IMedicalRegistryRepository
    { 
         MedicalRegistry getById(int recordId); 
         ICollection<MedicalRegistry> getPatientMedicalRegistries(int patientId); 
         ICollection<MedicalRegistry> getPatientRecordForTimePeriod(int patientId,DateTime fromDate, DateTime toDate); 
    }
}