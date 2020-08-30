using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCare.API.Model
{
    public class Hospitalization
    {   
        [Key]
        [ForeignKey("PatientId")]
        public int Id {get;set;}
/*         public Patient Patient; */
        public Patient Patient {get;set;}       
        public virtual int PatientId {get;set;}
        public DateTime IncomeDate {get;set;}
        public DateTime EstimatedLeave {get;set;}
/*         public Unit Unit {get;set;}
 */
    }

}