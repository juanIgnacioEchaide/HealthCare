using System;

namespace HealthCare.API.Model
{
    public abstract class BasePerson
    {
        private int LegalId { get; set; }
        private int SocialSecurityNumber { get; set; }
        private String Email { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private byte Age { get; set; }
        private String Address { get; set; }
    }
}