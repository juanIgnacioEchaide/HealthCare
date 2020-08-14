﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Model
{
    public class Physician
    {
        public int Id { get; set; }
        public int LegalId { get; set; }
        public int SocialSecurityNumber { get; set; }
        public String Email { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public byte Age { get; set; }
        public String Address { get; set; }        
        public String License { get; set; } 
        public String Specialty {get;set;}
        public ICollection<PatientPhysician> Patients { get; set; }
    }
}
