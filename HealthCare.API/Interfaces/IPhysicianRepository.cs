using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IPhysicianRepository
    {
        Physician getById(int physicianId);
        Physician getByLicense(string license);
        Physician getByFullName(string firstName, string lastName);
        ICollection<Physician> getBySpecialty(string specialty);
        ICollection<PatientPhysician> getPhysiciansByPatientId(int patientId);

    }
}