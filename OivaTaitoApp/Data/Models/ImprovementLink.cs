using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Data.Models
{
    public class ImprovementLink
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string LinkUrl { get; set; }

        [Required]
        [MaxLength(100)]
        public string LinkTitle { get; set; }

        public int EvalImprovementId { get; set; }
        public EvalImprovement EvalImprovement { get; set; }
    }
}
