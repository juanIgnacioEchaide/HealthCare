using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public interface IRegister
    {
        void createRegistry();
        void deleteRegistry();
        void updateRegistry();
    }

    public class ManageMedicalRegistry : IRegister
    {
       
        public void createRegistry()
        {
            var createdRegistry = new MedicalRegistry() {
            //Technician = ;
            //Physician = ;
            //Practice = ;
            //AttentionDate = ;
            //Institution = ;
            //AttentionSummary = ;
            //HealthCareProvider = ;
            //UnderMedication = ;
            };
        }

        public void deleteRegistry()
        {
            throw new NotImplementedException();
        }

        public void checkUpdatedElement()
        {
            var updated = "";
                
        }
        public void updateRegistry()
        {
            //Technician = (updated="technician") ?  : ;
            //Physician = (updated="physician") ?  : ;
            //Practice =  (updated="practice") ?  :;
            //AttentionDate = (updated="date") ?  :;
            //Institution = (updated="institution") ?  : ;
            //AttentionSummary = (updated="summary") ?  :;
            //HealthCareProvider = (updated="provider") ?  : ;
            //UnderMedication = (updated="medicated") ?  : ;
            throw new NotImplementedException();
        }
    }
}
