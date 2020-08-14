namespace HealthCare.API.Model
{
    public class PatientPhysician
    {
        public int PhysicianId {get;set;}
        public Physician Physician {get;set;}
        public int PatientId {get; set;}
        public Patient Patient {get; set;}
    }
}