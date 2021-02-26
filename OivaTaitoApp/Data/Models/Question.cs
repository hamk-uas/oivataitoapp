using System.ComponentModel.DataAnnotations;

namespace OivaTaitoApp.Data.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; }

        [Required]
        [MaxLength(10)]
        public string Identifier { get; set; }

        public int QuestionSetId { get; set; }
        public QuestionSet QuestionSet { get; set; }
    }
}
