using System.Linq;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class MedicalRecordRepository: IMedicalRecordRepository
    {
         private readonly DataContext _context;
         public MedicalRecordRepository(DataContext context)
         {
             _context = context;
         }

         public MedicalRecord GetMedicalRecordByPatientId(int patientId)
            =>this._context.MedicalRecords
            .Where(m=>m.PatientId == patientId)
            .FirstOrDefault();

        }
}