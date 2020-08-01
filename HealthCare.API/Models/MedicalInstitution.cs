using System;
using System.Collections.Generic;

namespace HealthCare.API.Models
{
    public class MedicalInstitution
    {
         private  long ID;
        private List<Patient> patients;
        private String Name { get; set; }
        private Int32 RegistrationNumber { get; set; }
        private String Address { get; set; }
        private long MedicalMatricule { get; set; }
        private IList<Int32> Telephones { get; set; }
    }
}
