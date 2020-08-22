using System;
using System.Collections.Generic;
using System.Linq;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class TechnicianRepository : ITechnicianRepository
    {
        private readonly DataContext _context;
        public TechnicianRepository(DataContext context)
        {
            _context = context;
        }

        public Technician getById(int physicianId)
        => this._context.Technicians
        .Where( p => p.Id == physicianId)
        .FirstOrDefault();

        public Technician getByLicense(string license)
        => this._context.Technicians
        .Where( p => p.License == license)
        .FirstOrDefault();
        
        public Technician getByFullName(string firstName, string lastName)
        => this._context.Technicians
        .Where( p => p.FirstName == firstName && p.LastName == lastName)
        .FirstOrDefault();

        public ICollection<Technician> getBySpecialty(string specialty)
        => this._context.Technicians
        .Where(p => p.Specialty == specialty) 
        .ToList();

    }
}