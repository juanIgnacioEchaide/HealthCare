using HealthCare.API.Data;
using HealthCare.API.DTO;
using HealthCare.API.Model;
using HealthCare.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly DataContext _context;
        private readonly PatientRepository _patientRepo;
        
        public PatientController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public Patient getPatientForRegistry(MedicalRegistryForCreateDTO dto)
        {
            
            var registryPatient = _patientRepo.getByPatientId(dto.Patient.Id);

            return registryPatient;
        }
    }
}