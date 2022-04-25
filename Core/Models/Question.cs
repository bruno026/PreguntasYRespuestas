using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public List<Answer> Answers { get; set; }
        public Category Category { get; set; }
    }
}
