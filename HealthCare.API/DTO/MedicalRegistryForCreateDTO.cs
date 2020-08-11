using System;
using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.DTO
{
    public class MedicalRegistryForCreateDTO
    {
        public  long ID;
        public Patient Patient {get ; set;}
        public MedicalRecord Record {get;set;}
        public  Technician Technician { get; set; }
        public  Physician Physician { get; set; }
        public  HealthCareProvider HealthCareProvider { get; set; }
        public List<String> Medications {get;set;}
        public DateTime DateOfAttendance { get; set; }
    }
}