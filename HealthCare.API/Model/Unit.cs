using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthCare.API.Model
{
    public class Unit
    {   
        public int Id;
        public string name;
        public Physician Director;
        public List<Physician> MedicalTeam;
        public List<Technician> TechnicalTeam;
    }
}