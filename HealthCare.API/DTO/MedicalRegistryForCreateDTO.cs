using System;
using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.DTO
{
    public class MedicalRegistryForCreateDTO
    {
        public  int Id;
        public int PatientId;
        public int MedicalRecordId;
        public int TechnicianId;
        public int PhysicianId;
        public int HealthCareProviderId;
        public DateTime DateOfAttendance { get; set; }
        public string Summary {get;set;}

        public Patient Patient {get ; set;}
        public MedicalRecord Record {get;set;}
        public  Technician Technician { get; set; }
        public  Physician Physician { get; set; }
        public  HealthCareProvider HealthCareProvider { get; set; }
        public List<String> Medications {get;set;}
      
    }
}