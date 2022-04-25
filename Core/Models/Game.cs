using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Score Score { get; set; }
        public int ScoreId { get; set; }
        public DificultyLevelEnum CurrentDificultiyLevel { get; set; }
        public bool ActiveGame { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }

    }
}
