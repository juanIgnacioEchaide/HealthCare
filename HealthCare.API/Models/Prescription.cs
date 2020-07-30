using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Prescription
    {
        private long ID { get; set; }
        private int PrescriptionNumber { get; set; }
        private Physician PrecriptorPhysician { get; set; }
        private HealthCareProvider HealthCareProvider { get; set; }
        private bool UnderHCCoverage { get; set; }
        private String Medication { get; set; }

        public Prescription()
        {

        }
    }
}
