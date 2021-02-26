using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OivaTaitoApp.Data.Models
{
    public class SelfEvalResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public float Answer { get; set; }

        public int SelfEvaluationId { get; set; }
        public SelfEvaluation SelfEvaluation { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
