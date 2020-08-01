namespace HealthCare.API.Interfaces
{
    public interface IAfiliate<T> where T : class
    {
         T Afiliate(long id);
         void DeAfiliate(long id);
    }
}