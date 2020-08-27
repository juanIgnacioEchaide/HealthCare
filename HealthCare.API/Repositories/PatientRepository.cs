
using System;
using System.Collections.Generic;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;
using System.Linq;

namespace HealthCare.API.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;
        
        public PatientRepository(DataContext context)
        {
            _context = context;
        }
        public Patient getByPatientId(int patientId) 
            => this._context.Patients
            .Where( p => p.Id == patientId)
            .FirstOrDefault();
        public Patient getBySocialSecurityNumber(int ssNumber) 
            => this._context.Patients
            .Where( p => p.SocialSecurityNumber == ssNumber)
            .FirstOrDefault();
        public Patient getByPatientFullName(string firstName, string lastName) 
            => this._context.Patients
            .Where( p => p.FirstName == firstName && p.LastName == lastName)
            .FirstOrDefault();
        public ICollection<Patient> getByHCProviderId(int providerId)
            => this._context.Patients
            .Where(p => p.HealthCareProviderId == providerId)
            .ToList();      
        public Patient getByMedicalRecordId(int recordId)
            => this._context.Patients
            .Where(p => p.MedicalRecord.Id == recordId)
            .FirstOrDefault();   

        public Patient getByHCCredentialNumber(int credentialNumber)
            => this._context.Patients
            .Where(p => p.HCCredentialNumber == credentialNumber)
            .FirstOrDefault();

         
        public ICollection<PatientPhysician> getPatientsByPhysicianId(int physicianId)
        => this._context.Physicians
        .FirstOrDefault().Patients
        .Where(p => p.PhysicianId== physicianId)
        .ToList();

        public ICollection<Patient> getAllPatients()
        => this._context.Patients
        .ToList();
    }
}