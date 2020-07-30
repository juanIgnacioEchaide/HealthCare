using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MedicalRegistry
    {
        private Technician Technician { get; set; }
        private Physician Physician { get; set; }
        private PracticeType Practice { get; set; }
        private DateTime AttentionDate { get; set; }
        private MedicalInstitution Institution { get; set; }
        private String AttentionSummary { get; set; }
        private String HealthCareProvider { get; set; }
        private bool UnderMedication { get; set; }
        private Prescription Prescription { get; set; }
         

        public MedicalRegistry()
        {

        }       

    }
}
