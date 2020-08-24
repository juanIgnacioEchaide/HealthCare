
using System;
using System.Collections.Generic;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;
using System.Linq;

namespace HealthCare.API.Repositories
{
    public class MedicalRegistryRepository 
    {
        private readonly DataContext _context;
        
        public MedicalRegistryRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<MedicalRegistry> getById(int recordId) 
            => this._context.MedicalRegistries
            .Where( m => m.Id == recordId)
            .OrderByDescending(m => m.Date)
            .ToList();

        public ICollection<MedicalRegistry> getByTimePeriod(DateTime fromDate, DateTime toDate) 
        => this._context.MedicalRegistries
        .Where(m =>  m.Date >= fromDate && m.Date <= toDate)
        .OrderByDescending(m => m.Date)  
        .ToList(); 
    }
}