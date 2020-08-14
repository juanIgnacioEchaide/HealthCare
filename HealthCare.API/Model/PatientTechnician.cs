namespace HealthCare.API.Model
{
    public class PatientTechnician
    {
        public int TechnicianId {get;set;}
        public Technician Technician {get;set;}
        public int PatientId {get; set;}
        public Patient Patient {get; set;}
    }
}