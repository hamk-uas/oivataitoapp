using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OivaTaitoApp.Data.Models
{
    public class QuestionCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(10)]
        public string Identifier { get; set; }

        [StringLength(maximumLength:6, MinimumLength = 6)]
        public string ColorHex { get; set; }

        public List<QuestionSet> QuestionSets { get; set; }
    }
}
