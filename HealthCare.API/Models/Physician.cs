using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Models
{
    public class Physician : BasePerson
    {
        private long ID { get; set; }        
        public List<string> Licenses { get; set; }
        public List<MedicalInstitution> Institutions { get; set; }
        private  List<DateTime> DatesOfAttendance { get; set; }
        private List<Patient> Patients {get;set;}
    }
}
