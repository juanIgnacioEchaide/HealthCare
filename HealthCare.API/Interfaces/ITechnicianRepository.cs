using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface ITechnicianRepository
    {
        Technician getById(int physicianId);
        Technician getByLicense(string license);
        Technician getByFullName(string firstName, string lastName);
        ICollection<Technician> getBySpecialty(string specialty);
    }
}