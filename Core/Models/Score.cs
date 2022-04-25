using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Score
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
        public int Points { get; set; }
    }
}
