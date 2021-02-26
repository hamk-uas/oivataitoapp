using System.ComponentModel.DataAnnotations;

namespace OivaTaitoApp.Data.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength: 21, MinimumLength = 21)]
        public string GoogleId { get; set; }

        [Required]
        public bool initEvalCompleted { get; set; }
    }
}
