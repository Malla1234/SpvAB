using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;

namespace SpvAB.Models
{
    public class PersonModel
    {
        [Key]  // Primary Key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto set 
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string SocialSecurityNumber { get; set; } // kanske ska finnas annan form också om personen inte har pernr
        [Required]
        [StringLength(20)]
        public string Address { get; set; } // kanske behövs postort, postnummer också
        public string Phone { get; set; }
        public string BankAccountNumber { get; set; } 
        public string BankName { get; set; }

        // Ny egenskap för efterlevande
        [ForeignKey("Beneficiary")]
        public int? BeneficiaryID { get; set; }
        public BeneficiaryModel Beneficiary { get; set; } // Navigation property



        //Samanfattning
        // En person kan ha en eller flera försäkringar(InsuranceModel) och även en efterlevande(BeneficiaryModel) för en försäkring.
        // Varje försäkring har en specifik typ(InsuranceTypeModel). även här man skapar ny
        // Varje förmånstagare är kopplad till en specifik försäkring.
        // Relationerna är implementerade med hjälp av primärnycklar (Key) och utländska nycklar (ForeignKey), samt navigeringsattribut för att underlätta åtkomst till relaterade entiteter.

        //Entity Framework Code First-principen, 
        // SSMS/SQL-databasstruktur, men den definieras i form av C#-klasser.
    }
}
