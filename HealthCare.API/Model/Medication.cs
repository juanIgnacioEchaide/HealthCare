using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCare.API.Model
{
    public class Medication
    {
        [Key]
        [ForeignKey("MedicalRegistryId")]
        public int Id {get;set;}
        public string Name {get;set;}
        public string Fabricant {get;set;}
        public string GenericDrug {get;set;}
        public string PurchaseLot {get;set;}
        public DateTime DateOfPurchase {get;set;}     
        public MedicalRegistry MedicalRegistry {get; set;}     
        public virtual int MedicalRegistryId {get;set;}
    }
}