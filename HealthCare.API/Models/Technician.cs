using System;
using System.Collections.Generic;

namespace HealthCare.API.Models
{
    public class Technician : BasePerson
    {
        public long ID { get; private set; }
        public List<string> Licenses { get; set; }
        public List<MedicalInstitution> Institutions { get; set; }
        private  List<DateTime> DatesOfAttendance { get; set; }
        private List<Patient> Patients {get;set;}
    }
}
