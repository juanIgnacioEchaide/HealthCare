using System;
using System.Collections.Generic;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class PatientRepository 
    {
        public List<Patient> getAllByHCId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> getAllByInstitutionId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> getByDateOfAttendance(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Patient getById(long id)
        {
            throw new NotImplementedException();
        }

        public Patient getByLegalId(long id)
        {
            throw new NotImplementedException();
        }
    }
}