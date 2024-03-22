using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpvAB.Models
{
    public class InsuranceTypeModel
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsuranceTypeID { get; set; }

        [Required]
        public string TypeName { get; set; }

        // Allt som behövs för att skapa en ny försäkring 
    }
}
