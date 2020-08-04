using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Model
{
    public class Patient : BasePerson
    {
        public int ID { get; set; }

        //medical data
        public HealthCareProvider CurrentHCProvider { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
        public int HCCredentialNumber { get; set; }
    }
}
