using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MedicalInstitution
    {
        private String Name { get; set; }
        private Int32 RegistrationNumber { get; set; }
        private String Address { get; set; }
        private long MedicalMatricule { get; set; }
        private IList<Int32> Telephones { get; set; }

        public MedicalInstitution()
        {

        }
    }
}
