using System;

namespace HealthCare.API.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
         void Commit();
         void Rollback();
         void DetectChanges();
    }
}