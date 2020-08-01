using System;
using HealthCare.API.Interfaces;

namespace HealthCare.API.Models
{
    public class Prescription 
    {
        private long ID { get; set; }
        private Patient Patient { get; set; }
        private int PrescriptionNumber { get; set; }
        private Physician PrecriptorPhysician { get; set; }
        private HealthCareProvider HealthCareProvider { get; set; }
        private bool UnderHCCoverage { get; set; }
        private String Medication { get; set; }

    }
}
