using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OivaTaitoApp.Data.Models
{
    public class QuestionSet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(10)]
        public string Identifier { get; set; }

        public int QuestionCategoryId { get; set; }
        public QuestionCategory QuestionCategory { get; set; }

        public List<Question> Questions { get; set; }
    }
}
