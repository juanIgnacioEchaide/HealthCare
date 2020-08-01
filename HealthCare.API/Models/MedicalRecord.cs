using System;
using System.Collections.Generic;
using HealthCare.API.Interfaces;

namespace HealthCare.API.Models
{
    public  class MedicalRecord 
    {
        private  long ID;
        private  Patient Patient { get; }
        private  DateTime StartingDate { get; set; }
        private  List<DateTime> DatesOfAttendance { get; set; }
        private  List<MedicalRegistry> Registries { get; set; }
        private  int Quantity { get; set; }

    
    }
}
