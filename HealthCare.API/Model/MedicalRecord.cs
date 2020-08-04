using System;
using System.Collections.Generic;
using HealthCare.API.Interfaces;

namespace HealthCare.API.Model
{
    public  class MedicalRecord 
    {
        public  int Id { get; set; }
        public  int PatientId { get; set; }
        public  DateTime StartingDate { get; set; }
        public  ICollection<MedicalRegistry> MedicalRegistries { get; set; }  
   
    }
}
