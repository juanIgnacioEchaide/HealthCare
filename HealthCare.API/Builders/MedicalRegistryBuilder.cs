using System;
using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Builders
{
    public class MedicalRegistryBuilder 
    {
        private Patient _patient;
        private MedicalRecord _record;

        private  Physician _physician;
        private Technician _technician;
        private  HealthCareProvider _healthCareProvider;

        public MedicalRegistryBuilder withPatient(Patient patient)
        {
            _patient = patient;
            return this;
        }
   
         public MedicalRegistryBuilder withHealthCareProvider(HealthCareProvider healthCareProvider)
        {
              _healthCareProvider= healthCareProvider;
            return this;
        }
         public MedicalRegistryBuilder withPhysician(Physician physician)
        {
              _physician= physician;
            return this;
        }

        public MedicalRegistryBuilder withTechnician(Technician technician)
        {
              _technician= technician;
            return this;
        }
    
         public MedicalRegistry buildMedicalRegistry()
        {
           return new MedicalRegistry(){
                Patient = _patient,
                Physician = _physician,
                Technician = _technician,
                HealthCareProvider = _healthCareProvider,
            };
        }
     }
}