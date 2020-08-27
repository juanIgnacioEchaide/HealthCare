using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IPatientRepository
    {
        Patient getByPatientId(int patientId);
        Patient getBySocialSecurityNumber(int ssNumber);
        Patient getByPatientFullName(string firstName, string lastName);
        ICollection<Patient> getByHCProviderId(int providerId);  
        Patient getByMedicalRecordId(int recordId);
        ICollection<Patient> getAllPatients();
      
    }
}