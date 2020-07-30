using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Technician
    {
        public long ID { get; private set; }
        private int LegalID { get; set; }
        private String Email { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private String Address { get; set; }
        private String Matricule { get; set; }
        public Technician(long id, int legalId, String email, String firstName, String lastName, String address,String matricule)
        {
            LegalID = legalId;
            Email = email;
            FirstName = firstName; 
            LastName = lastName;
            Address = address;
            Matricule= matricule;
        }
    }
}
