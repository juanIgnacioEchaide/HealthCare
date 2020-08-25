using System.Collections.Generic;
using System.Linq;
using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Model;

namespace HealthCare.API.Repositories
{
    public class HealthCareProviderRepository: IHealthCareProviderRepository
    {
        private readonly DataContext _context;
        public HealthCareProviderRepository(DataContext context)
        {
            _context = context;
        }

        public HealthCareProvider GetById(int providerId)
             => this._context.HealthCareProviders
             .Where(p => p.Id == providerId)
             .FirstOrDefault();
        public ICollection<HealthCareProvider> GetAllProviders()
        => this._context.HealthCareProviders
        .ToList();
    }
}