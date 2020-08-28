using System;

namespace HealthCare.API.Model
{
    public class Medication
    {
        public int Id;
        public string Name;
        public string Fabricant;
        public string GenericDrug;
        public string PurchaseLot;
        public DateTime DateOfPurchase;
    }
}