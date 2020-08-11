using HealthCare.API.Builders;
using HealthCare.API.DTO;
using HealthCare.API.Model;

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
        . withTechnician(dto.Technician)  
        . withPhysician(dto.Physician)  
        . withHealthCareProvider(dto.HealthCareProvider) 
        .buildMedicalRegistry();

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
}