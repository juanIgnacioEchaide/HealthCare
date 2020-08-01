using HealthCare.API.Models;

namespace HealthCare.API.Interfaces
{
    public interface IMedicalRegistryBuilder{

        MedicalRegistry withTechnician(Technician technician);
        MedicalRegistry withPhysician(Physician physician);
        MedicalRegistry withPractice(Practice practice); 
        MedicalRegistry withAttentionDate(AttentionDate attentionDate); 
        MedicalRegistry withInstitution(Institution institution); 
        MedicalRegistry withAttentionSummary(AttentionSummary attentionSummary); 
        MedicalRegistry withHealthCareProvider(HealthCareProvider healthCareProvider); 
        MedicalRegistry withUnderMedication(UnderMedication underMedication); 
        MedicalRegistry withPrescription(Prescription prescription); 
        MedicalRegistry withPrescription(Prescription prescription); 
        MedicalRegistry BuildMedicalRegistry(Prescription prescription); 
    }
}
