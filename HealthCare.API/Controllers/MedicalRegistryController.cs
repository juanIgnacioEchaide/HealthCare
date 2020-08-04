using System;
using System.Threading.Tasks;
/* using HealthCare.API.DTO; */
using HealthCare.API.Model;
using HealthCare.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRegistryController : ControllerBase
    {
        private readonly IConfiguration _config;
  /*       private readonly RegisterMedicalRegistry _registryService; */
        public MedicalRegistryController(IConfiguration config)
        {
            _config = config;
        }

        //Todo make async and return 201 if ok 
/*         [HttpPost]
        public IActionResult CreateRegistry(MedicalRegistryForCreateDTO dto)
        {
            var createdRegistry = _registryService.createRegistry(dto);

            Console.WriteLine(createdRegistry);
            return StatusCode(201); 
        } */
    }
}