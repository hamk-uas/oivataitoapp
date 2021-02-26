using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Data.Models
{
    public class EvalImprovement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(2000)]
        public string ImprovementContent { get; set; }

        [MaxLength(300)]
        public string ImprovementVideoUrl { get; set; }

        public int QuestionSetId { get; set; }
        public QuestionSet QuestionSet { get; set; }
    }
}
