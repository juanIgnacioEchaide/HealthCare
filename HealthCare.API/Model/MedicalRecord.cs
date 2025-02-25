﻿using System;
using System.Collections.Generic;

namespace HealthCare.API.Model
{
    public  class MedicalRecord 
    {
        public  int Id { get; set; }
        public  int PatientId { get; set; }
        public  DateTime StartingDate { get; set; }
        public  ICollection<MedicalRegistry> MedicalRegistries { get; set; }

    }
}
