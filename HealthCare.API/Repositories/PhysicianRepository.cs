using System;
using System.Collections.Generic;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class PhysicianRepository 
    {
        public List<Physician> getAllByHCId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Physician> getAllByInstitutionId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Physician> getByDateOfAttendance(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Physician getById(long id)
        {
            throw new NotImplementedException();
        }

        public Physician getByLegalId(long id)
        {
            throw new NotImplementedException();
        }
    }
}