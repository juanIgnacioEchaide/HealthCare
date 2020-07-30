using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MedicalRecord
    {
        private long ID;
        private Patient Patient { get; }
        private DateTime StartingDate { get; set; }
        private DateTime ReportDate { get; set; }
        private ICollection<MedicalRegistry> Registries { get; set; }
        public int Quantity { get; private set; }

          public MedicalRecord(ICollection<MedicalRegistry> _registries,Patient patient, DateTime dateTime) 
            {
            Registries = _registries;
            }
       

    }

  

}
