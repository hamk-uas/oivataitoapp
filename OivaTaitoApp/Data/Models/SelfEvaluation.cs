using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Data.Models
{
    public class SelfEvaluation
    {
        [Key]
        public int Id { get; set; }

        public int EvaluatorId { get; set; }
        public AppUser Evaluator { get; set; }

        [Required]
        public DateTime EvaluatedAt { get; set; }

        public List<SelfEvalResult> SelfEvalResults { get; set; }
    }
}
