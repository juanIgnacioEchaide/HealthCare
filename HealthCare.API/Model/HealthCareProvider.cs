using System;
using System.Collections.Generic;

namespace HealthCare.API.Model
{
    public class HealthCareProvider
    {
        
        public int Id { get; set; }
        public ICollection<Patient> patients;
        public String Name { get; set; }
        public String Email { get; set; }
        public string Telephone { get; set; } 
        public String Address { get; set; }
        public String MedicalPlan { get; set; }
    }
}
