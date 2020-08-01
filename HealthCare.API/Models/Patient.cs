using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.API.Models
{
    public class Patient : BasePerson
    {
        private long ID { get; set; }

        //medical data
        private String CurrentHCProvider { get; set; }
        private MedicalRecord MedicalRecord { get; set; }
        private long HCCredentialNumber { get; set; }
         private  List<DateTime> DatesOfAttendance { get; set; }
        private List<Physician> Physicians { get; set; }
        private List<Technician> Technicians { get; set; }     
        private List<Prescription> Prescriptions { get; set; }      

    }
}
