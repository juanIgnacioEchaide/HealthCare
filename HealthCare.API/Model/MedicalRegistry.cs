using System;
using System.Collections.Generic;

namespace HealthCare.API.Model
{
    public class MedicalRegistry
    {
        public int Id { get; set; }
        public int MedicalRecordId {get;set;}
        public Patient Patient { get; set; }
        public HealthCareProvider HealthCareProvider { get; set; }
        public Physician Physician { get; set; }
        public Technician Technician  { get; set; }
        public List<MedicalRegistryMedication> Medications {get;set;}
        public string Summary { get; set; }
        public DateTime Date  {get;set;}
    }
}