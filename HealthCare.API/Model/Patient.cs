using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Model
{
    public class Patient 
    {
        public int Id { get; set; }
        public int SocialSecurityNumber { get; set; }
        private String Email { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        private byte Age { get; set; }
        private String Address { get; set; }

        //medical data
        public int HealthCareProviderId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
        public int HCCredentialNumber { get; set; }
        public ICollection<PatientPhysician> physicians {get;set;}
        public List<PatientTechnician> technicians {get;set;}
        public List<Hospitalization> hospitalizations {get;set;}
    }
}
