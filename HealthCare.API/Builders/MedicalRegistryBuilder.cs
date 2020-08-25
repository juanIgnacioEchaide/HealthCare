using System;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Builders
{
    public class MedicalRegistryBuilder : IMedicalRegistryBuilder
    {
        private readonly UnitOfWork _uow;
        private Patient _patient;
        private MedicalRecord _medicalRecord;
        private Physician _physician;
        private Technician _technician;
        private DateTime _date;
        private HealthCareProvider _healthCareProvider;
        private string _summary;

        public Patient withPatient(int patientId)
        {
            return _patient = _uow.PatientRepository.getByPatientId(patientId); /* ?? */
                                     //dispara el patient service 'crea el patient'
        }

        public MedicalRecord checkForMedicalRecord(int patientId)
        {
            return _medicalRecord = _uow.MedicalRecordRepository.GetMedicalRecordByPatientId(patientId)??
                                    new MedicalRecord(){
                                        PatientId = patientId,
                                        StartingDate = DateTime.Now                                   
                                    };
        }

        public HealthCareProvider withHealthCareProvider(int providerId)
        {
            return _healthCareProvider = _uow.HealthCareProviderRepository.GetById(providerId);
        } 
        public Physician withPhysician(int physicianId)
        {
            return   physicianId.ToString() == null ?
                    _physician = null:
                    _physician = _uow.PhysicianRepository.getById(physicianId);
        // ?? throw exception
        }

        public Technician withTechnician(int techicianId)
        {
            return   techicianId.ToString() == null ?
                    _technician = null:
                    _technician = _uow.TechnicianRepository.getById(techicianId);
        }

        public DateTime withDate(DateTime date)
        {
            return _date = date;
        }

        public string withSummary(string summary)
        {
            return _summary = summary;
        }

        public MedicalRegistry buildMedicalRegistry(){
            return new MedicalRegistry()
                        {
                        Patient = _patient,
                        Physician =_physician,
                        MedicalRecordId = _medicalRecord.Id,
                        Technician= _technician,
                        Date =_date,
                        HealthCareProvider = _healthCareProvider,
                        Summary = _summary
                        };
            }
      
    }
}