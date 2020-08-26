using System;
using System.Collections.Generic;
using HealthCare.API.Data;
using HealthCare.API.Model;

namespace HealthCare.API.Builders
{
    public class MedicalRegistryBuilder
    {
        private readonly UnitOfWork _uow;
        private MedicalRegistry _medicalRegistry;
        private int _medicalRecordId;
        private Patient _patient;
        private Technician _technician;
        private Physician _physician;
        private DateTime _date;
        private HealthCareProvider _healthCareProvider;
        private string _summary;
        private List<string> _medications;

        public MedicalRegistryBuilder withMedicalRecordId(int patientId){
            
           var medicalRecordId = _uow.MedicalRecordRepository.GetMedicalRecordByPatientId(patientId).Id;
            medicalRecordId = _medicalRecordId;
            return this;
        }
        public MedicalRegistryBuilder withPatient(int patientId)
        {
            var patient = _uow.PatientRepository.getByPatientId(patientId);
              _patient = patient;    
            return this;
        }
        public MedicalRegistryBuilder withTechnician(int technicianId)
        {
            var technician = _uow.TechnicianRepository.getById(technicianId);
              _technician = technician;
            return this;
        }

        public MedicalRegistryBuilder withPhysician(int physicianId)
        {
            var physician = _uow.PhysicianRepository.getById(physicianId);
            _physician = physician;
            return this;
        }
        public MedicalRegistryBuilder withDate(DateTime date)
        {
            _date = date;
            return this;
        }
        public MedicalRegistryBuilder withHealthCareProvider(int providerId)
        {
            var healthCareProvider = _uow.HealthCareProviderRepository.GetById(providerId);
            _healthCareProvider = healthCareProvider;
            return this;
        }

        public MedicalRegistryBuilder withSummary(string summary)
        {
            _summary = summary;
            return this;
        }

        public MedicalRegistryBuilder withMedications(List<string> medications)
        {
            _medications = medications;
            return this;
        }
        public MedicalRegistry Build()
        {
            return new MedicalRegistry(){
                MedicalRecordId = _medicalRecordId,
                Patient = _patient,
                Technician = _technician,
                Physician = _physician,
                Date = _date,
                HealthCareProvider= _healthCareProvider,
                Medications = _medications,
                Summary= _summary
           };  
        }
      
    }
}