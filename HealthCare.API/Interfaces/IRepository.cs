using System;
using System.Collections.Generic;

namespace HealthCare.API.Interfaces
{
    public interface IPersonRepository<T> where T : class
    {
         T getById(long id);
         T getByLegalId(long id);
         List<T> getAllByHCId(long id);
         List<T> getAllByInstitutionId(long id);
         List<T> getByDateOfAttendance(DateTime date);

    }
}