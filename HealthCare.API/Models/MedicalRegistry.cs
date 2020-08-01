using System;
using System.Collections.Generic;
using HealthCare.API.Interfaces;

namespace HealthCare.API.Models
{
    public  class MedicalRegistry 
    {
         private  long ID;
        private MedicalRecord Record {get;set;}
        private  Technician Technician { get; set; }
        private  Physician Physician { get; set; }
        private  PracticeType Practice { get; set; }
        private  MedicalInstitution Institution { get; set; }
        private  String AttendanceSummary { get; set; }
        private  String HealthCareProvider { get; set; }
        private  bool UnderMedication { get; set; }
        private List<String> Medications {get;set;}
        private  Prescription Prescription { get; set; }
        private DateTime DateOfAttendance { get; set; }

}
