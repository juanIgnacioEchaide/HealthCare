using System;
using System.Collections.Generic;

namespace HealthCare.API.Models
{
    public class HealthCareProvider
    {
        private long ID { get; set; }
        private List<Patient> patients;
        private String Name { get; set; }
        private String Email { get; set; }
        private IList<Int32> Telephones { get; set; }
        private String Address { get; set; }
        private String MedicalPlan { get; set; }
    }
}
