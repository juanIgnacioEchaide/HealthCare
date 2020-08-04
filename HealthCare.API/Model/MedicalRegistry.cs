namespace HealthCare.API.Model
{
    public class MedicalRegistry
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public HealthCareProvider HealthCareProvider { get; set; }
        public Physician Physician { get; set; }
        public string Summary { get; set; }
    }
}