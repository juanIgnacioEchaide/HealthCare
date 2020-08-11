using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Model
{
    public class Patient 
    {
        public int ID { get; set; }
        private int LegalId { get; set; }
        private int SocialSecurityNumber { get; set; }
        private String Email { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private byte Age { get; set; }
        private String Address { get; set; }

        //medical data
        public HealthCareProvider CurrentHCProvider { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
        public int HCCredentialNumber { get; set; }
    }
}
