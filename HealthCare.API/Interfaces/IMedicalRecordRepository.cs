using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IMedicalRecordRepository
    {
          MedicalRecord GetMedicalRecordByPatientId(int patientId);
    }
}