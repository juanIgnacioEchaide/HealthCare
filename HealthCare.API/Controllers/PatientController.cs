using System.Collections.Generic;
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
        private readonly UnitOfWork _uow;
        
        public PatientController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public ActionResult<ICollection<Patient>> getAllPatients(){

            var patients = _uow.PatientRepository.getAllPatients();

            return Ok(patients);
        }

        [HttpGet("{id}")]
        public ActionResult getPatientById(int id)
        {          
            var patient = _uow.PatientRepository.getByPatientId(id);
            
            return Ok(patient);
        }
    }
}