using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Model
{
    public class Physician
    {
        public long ID { get; set; }
        private int LegalId { get; set; }
        private int SocialSecurityNumber { get; set; }
        private String Email { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private byte Age { get; set; }
        private String Address { get; set; }        
       public String License { get; set; } 
       public ICollection<Patient> Patients {get;set;}
    }
}
