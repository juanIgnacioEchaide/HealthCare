using System.Collections.Generic;
using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IHealthCareProviderRepository
    {
     HealthCareProvider GetById(int providerId);
     ICollection<HealthCareProvider> GetAllProviders();
    }
}