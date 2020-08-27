using System;
using System.Collections.Generic;
using HealthCare.API.Builders;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IMedicalRegistryBuilder{
        MedicalRegistryBuilder withMedicalRecordId(int patientId);
        MedicalRegistryBuilder withPatient(int patientId);
        MedicalRegistryBuilder withTechnician(int technicianId);
        MedicalRegistryBuilder withPhysician(int physicianId);
        MedicalRegistryBuilder withDate(DateTime date);
        MedicalRegistryBuilder withHealthCareProvider(int providerId);
        MedicalRegistryBuilder withSummary(string summary);
        MedicalRegistryBuilder withMedications(List<string> medications);   
        MedicalRegistry Build();
    }
}
