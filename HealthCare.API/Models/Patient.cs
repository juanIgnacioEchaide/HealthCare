using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Patient
    {
        private long ID { get; set; }

        //personal data
        private int LegalID { get; set; }
        private int SocialSecurityNumber { get; set; }
        private String Email { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private byte Age { get; set; }
        private String Address { get; set; }

        //medical data
        private String CurrentHCProvider { get; set; }
        private MedicalRecord MedicalRecord { get; set; }
        private long HCCredentialNumber { get; set; }

       
       public Patient()
        {

        }


    }
}
