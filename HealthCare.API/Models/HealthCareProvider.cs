using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HealthCareProvider
    {
        private long ID { get; set; }
        private String Name { get; set; }
        private String Email { get; set; }
        private IList<Int32> Telephones { get; set; }
        private String Address { get; set; }
        private String MedicalPlan { get; set; }

        public HealthCareProvider()
        {

        }
    }
}
