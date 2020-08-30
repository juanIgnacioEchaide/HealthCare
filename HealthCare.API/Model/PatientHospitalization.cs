namespace HealthCare.API.Model
{
    public class PatientHospitalization
    {
        public int Id {get;set;}
        public int PatientId {get;set;}
        public virtual Patient Patient {get;set;}
        public int HospitalizationId {get;set;}
        public virtual Hospitalization Hospitalization {get;set;}
    }
}