
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
        public ICollection<Patient> getByHCProviderName(string provider)
            => this._context.Patients
            .Where(p => p.CurrentHCProvider.Name == provider)
            .ToList();      
        public Patient getByMedicalRecordId(int recordId)
            => this._context.Patients
            .Where(p => p.MedicalRecord.Id == recordId)
            .FirstOrDefault();   

        public Patient getByHCCredentialNumber(int credentialNumber)
            => this._context.Patients
            .Where(p => p.HCCredentialNumber == credentialNumber)
            .FirstOrDefault();
 /*        public ICollection<Patient> getByPhysicianId(int physicianId)
            => this._context.Physicians
            .Where(p => p.Id == physicianId)
            .FirstOrDefault()
            .Patients;
        public ICollection<Patient> getByPhysicianSpecialty(string specialty)
            => this._context.Physicians
            .Where(p => p.Specialty == specialty)
            .FirstOrDefault()
            .Patients; */
    }
}