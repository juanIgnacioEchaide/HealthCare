using System;
using System.Collections.Generic;
using System.Linq;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class PhysicianRepository : IPhysicianRepository 
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

         public ICollection<PatientPhysician> getPhysiciansByPatientId(int patientId)
        => this._context.Patients
        .FirstOrDefault().physicians
        .Where(p => p.PatientId == patientId)
        .ToList();

    }
}