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
    public class PhyisicianController : ControllerBase
    {
       private readonly IConfiguration _config;
        private readonly UnitOfWork _uow;
    /*     private readonly string criteria; */
        public PhyisicianController(IConfiguration configuration)
        {
            _config = configuration;
        }

     /*    public void SwitchRequest(string criteria){
            switch(criteria){
            default:

            };

        } */
       

        [HttpGet("{id}")]
        public ActionResult getPhysicianById(int id)
        {          
            var physician = _uow.PhysicianRepository.getById(id);
            
            return Ok(physician);
        }

        [HttpGet("{specialty}")]
        public ActionResult<ICollection<Physician>> getPhysicianById(string specialty)
        {          
            var specialists = _uow.PhysicianRepository.getBySpecialty(specialty);
            
            return Ok(specialists);
        }

    }
}