using System;
using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IRepository<T> where T: class
    {
        
        T getById(int registryId);
         ICollection<T> getByPatientId(int patientId);
         ICollection<T> getSince(int patientId,DateTime date);
         ICollection<T> GetFromToDate(int patientId,DateTime From, DateTime To);
         ICollection<T> getByProfessionalAndPatient(int professionalId,int patientId);
         

    }
}