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
    public class TechnicianController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly DataContext _context;
        private readonly TechnicianRepository _technicianRepo;
        
        public TechnicianController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet("{id}")]
        public ActionResult getPhysicianById(MedicalRegistryForCreateDTO dto)
        {
            
            var physician = _technicianRepo.getById(dto.Technician.Id);


            return Ok(physician);
        }
    }
}