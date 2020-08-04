/*using HealthCare.API.Builders;
using HealthCare.API.DTO;
using HealthCare.API.Models;

namespace HealthCare.API.Services
{
    public class RegisterMedicalRegistry 
    {
        //Todo call 'await unitOfWork.SaveRegistry();
        public MedicalRegistry createRegistry(MedicalRegistryForCreateDTO dto)
        {       
        //declaration of builder
        var _builder = new MedicalRegistryBuilder();

        //instance of builder with dto's data
        MedicalRegistry newMedicalRegistry = _builder
        . withPatient(dto.Patient) 
        . withMedicalRecord(dto.Record) 
        . withTechnician(dto.Technician)  
        . withPhysician(dto.Physician)  
        . withPracticeType(dto.Practice)
        . withAttendace(dto.Attendace)  
        . withMedicalInstitution(dto.Institution)  
        . withAttentionSummary(dto.AttentionSummary)  
        . withHealthCareProvider(dto.HealthCareProvider) 
        . withMedications(dto.Medications)
        . withPrescription(dto.Prescription) 
        . withDateOfAttendance(dto.DateOfAttendance)
        . withUnit(dto.Unit)
        . withHospitalization(dto.Hospitalization)
        .buildMedicalRegistry();

        //write registry in db
        //BeginTransaction
        
        return newMedicalRegistry;
        }

        public void deleteRegistry(long Id)
        {

            throw new System.NotImplementedException();
        }

        public MedicalRegistry updateRegistry(long Id)
        {
            throw new System.NotImplementedException();
        }
    }
}*/