
using System;
using System.Collections.Generic;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;
using System.Linq;

namespace HealthCare.API.Repositories
{
    public class MedicalRegistryRepository: IMedicalRegistryRepository
    {
        private readonly DataContext _context;
        
        public MedicalRegistryRepository(DataContext context)
        {
            _context = context;
        }
        public MedicalRegistry getById(int recordId) 
            => this._context.MedicalRegistries
            .Where( m => m.Id == recordId)
            .FirstOrDefault();

        public MedicalRecord GetMedicalRecordByPatientId(int patientId)
        {
            throw new NotImplementedException();
        }

        public ICollection<MedicalRegistry> getPatientMedicalRegistries(int patientId) 
        => this._context.MedicalRegistries
        .Where(p => p.Patient.Id == patientId)
        .OrderByDescending(m => m.Date)
        .ToList();

        public ICollection<MedicalRegistry> getPatientRecordForTimePeriod(int patientId,DateTime fromDate, DateTime toDate) 
        => this._context.MedicalRegistries
        .Where(m =>  (m.Date >= fromDate && m.Date <= toDate) &&
                      m.Patient.Id == patientId)
        .OrderByDescending(m => m.Date)  
        .ToList(); 
    }
}