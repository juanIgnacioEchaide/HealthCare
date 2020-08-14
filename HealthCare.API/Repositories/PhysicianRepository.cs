using System;
using System.Collections.Generic;
using System.Linq;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class PhysicianRepository 
    {
        private readonly DataContext _context;

        public PhysicianRepository(DataContext context)
        {
            _context = context;
        }

        public Physician getById(int physicianId)
        => this._context.Physicians
        .Where( p => p.Id == physicianId)
        .FirstOrDefault();

        public Physician getByLicense(string license)
        => this._context.Physicians
        .Where( p => p.License == license)
        .FirstOrDefault();
        
        public Physician getByFullName(string firstName, string lastName)
        => this._context.Physicians
        .Where( p => p.FirstName == firstName && p.LastName == lastName)
        .FirstOrDefault();

        public ICollection<Physician> getBySpecialty(string specialty)
        => this._context.Physicians
        .Where(p => p.Specialty == specialty) 
        .ToList();

/*         public ICollection<Physician> getPhysiciansByPatientId(int patientId)
        => this._context.Physicians
        .FirstOrDefault().Patients
        .Where(p => p.Id == patientId)
        .FirstOrDefault().physicians
        .ToList();

        public ICollection<Physician> getPhysiciansByPatientFullName(string firstName, string lastName)
            => this._context.Physicians
            .FirstOrDefault().Patients
            .Where(p => p.FirstName == firstName && 
                p.LastName == lastName)
            .FirstOrDefault().physicians
            .ToList();
       
       public ICollection<Physician> getPhysiciansByPatientHCCredentialNumber(int credentialNumber)
            => this._context.Physicians
            .FirstOrDefault().Patients
            .Where(p => p.HCCredentialNumber == credentialNumber)
            .FirstOrDefault().physicians
            .ToList(); */
    }
}