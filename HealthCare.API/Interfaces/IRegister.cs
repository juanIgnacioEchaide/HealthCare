using HealthCare.API.Model;

namespace HealthCare.API.Interfaces
{
    public interface IRegister<T> where T : class
    {
       T createRegistry(long Id);  
       T updateRegistry(long Id);  
       void deleteRegistry(long Id);
    }
}