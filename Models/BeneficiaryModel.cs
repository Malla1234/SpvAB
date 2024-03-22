using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpvAB.Models
{
    public class BeneficiaryModel
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BeneficiaryID { get; set; }  // efterlevande
        public string FullName { get; set; } 
        public string Relationship { get; set; }
        [Required]
        [StringLength(30)]
        public string SocialSecurityNumber { get; set; } // Behövs troligtvis?
        [Required]
        [StringLength(30)]

        [ForeignKey("InsuranceModel")] // Foreign Key
        public int InsuranceID { get; set; }  
        public InsuranceModel Insurance { get; set; } // Navigation property





        //En Navigation Property i Entity Framework är en egenskap i en modellklass som representerar relationen till en annan modellklass.
        //Den används för att definiera och navigera förhållandet mellan två entiteter. exempel:
        // Insurance är Navigation Property i klassen BeneficiaryModel.
        //Detta används för att definiera relationen mellan BeneficiaryModel och InsuranceModel.
        //Det ger dig möjlighet att navigera från en förmånstagare till den försäkring som de är kopplade till.
        // Så, när du exempelvis har en förmånstagareinstans beneficiary, kan du komma åt försäkringsinformationen genom att använda beneficiary.Insurance
        // Detta hjälper till att göra det lättare att navigera och utföra åtgärder som involverar relationen mellan förmånstagare och försäkringar.
    }
}
