using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Data.Models
{
    public class EvalFeedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public float MinPts { get; set; }

        [Required]
        public float MaxPts { get; set; }

        [Required]
        [MaxLength(500)]
        public string FeedbackContent { get; set; }

        public int QuestionSetId { get; set; }
        public QuestionSet QuestionSet { get; set; }
    }
}
