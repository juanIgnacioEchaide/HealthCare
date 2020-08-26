using HealthCare.API.Builders;
using HealthCare.API.Data;
using HealthCare.API.DTO;
using HealthCare.API.Model;

namespace HealthCare.API.Services
{
    public class RegisterMedicalRegistry 
    {
       private UnitOfWork _uow;
       
        public void _createRegistry(MedicalRegistryForCreateDTO dto)
        {          
            new MedicalRegistryBuilder()
                .withMedicalRecordId(dto.PatientId)
                .withPatient(dto.PatientId)
                .withHealthCareProvider(dto.HealthCareProviderId)
                .withDate(dto.DateOfAttendance)
                .withSummary(dto.Summary)
                .Build();  
            _uow.Commit();
            
            } 

            public void _updateRegistry(MedicalRegistryForCreateDTO dto)
            {
                var dbRegistry = _uow.MedicalRegistryRepository.getById(dto.Id);
                
                 _uow.DetectChanges();

            }

             public void deleteRegistry(long Id)
            {
                _uow.Rollback();
            }
    }
}