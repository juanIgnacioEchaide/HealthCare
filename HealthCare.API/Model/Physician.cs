using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Model
{
    public class Physician: BasePerson 
    {
        public long ID { get; set; }        
       public String License { get; set; } 
       public ICollection<Patient> Patients {get;set;}
    }
}
