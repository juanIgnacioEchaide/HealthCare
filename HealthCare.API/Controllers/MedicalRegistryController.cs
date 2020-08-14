using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthCare.API.Data;
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
        private readonly DataContext _context;
        public MedicalRegistryController(IConfiguration config)
        {
            _config = config;
        }

  /*    [HttpGet]
        public IEnumerable<MedicalRegistry> Get()
        {
            return 
        } */
    }
}