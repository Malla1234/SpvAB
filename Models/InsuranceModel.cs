using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SpvAB.Models
{
    public class InsuranceModel
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsuranceID { get; set; }
        [Required]
        public string PolicyNumber { get; set; } // dessa skulle kunna vara i insurancetypemodel 

        [Required]
        [Range(200, double.MaxValue, ErrorMessage = "Premium måste vara minst 200 SEK.")]
        public decimal CoverageAmount { get; set; }
        [Required]

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public decimal Premium { get; set; }

        [ForeignKey("PersonModel")] // Foreign Key
        public int PersonID { get; set; }     
        public PersonModel Person { get; set; } // Navigation property

        [ForeignKey("InsuranceTypeModel")] // Foreign Key
        public int InsuranceTypeID { get; set; }

        public InsuranceTypeModel insuranceType{ get; set; } // Navigation property


      //  [Range]-dataannotationen med det angivna intervallet[200, double.MaxValue]
      //  innebär det att Premium-egenskapen inte kan vara mindre än 200 eller större än double.MaxValue,
      //  vilket är en extremt stor positivt tal.Således kan Premium-värdet inte vara negativt eller mindre än 200 SEK.
      //  Detta garanterar att värdet aldrig kommer att vara lägre än 200 SEK och inte negativt,


    }
}
