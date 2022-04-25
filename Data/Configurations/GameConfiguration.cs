using Core.Enums;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game { Id = 1, UserId = 1, ScoreId = 1, CurrentDificultiyLevel=DificultyLevelEnum.Normal, ActiveGame=false},
                new Game { Id = 2, UserId = 1, ScoreId = 2, CurrentDificultiyLevel = DificultyLevelEnum.Normal, ActiveGame = false },
                new Game { Id = 3, UserId = 1, ScoreId = 3, CurrentDificultiyLevel = DificultyLevelEnum.Easy, ActiveGame = false },
                new Game { Id = 4, UserId = 1, ScoreId = 4, CurrentDificultiyLevel = DificultyLevelEnum.Easy, ActiveGame = false },
                new Game { Id = 5, UserId = 2, ScoreId = 5, CurrentDificultiyLevel = DificultyLevelEnum.Extreme, ActiveGame = false },
                new Game { Id = 6, UserId = 2, ScoreId = 6, CurrentDificultiyLevel = DificultyLevelEnum.Normal, ActiveGame = false },
                new Game { Id = 7, UserId = 1, ScoreId = 7, CurrentDificultiyLevel = DificultyLevelEnum.Easy, ActiveGame = false },
                new Game { Id = 8, UserId = 1, ScoreId = 8, CurrentDificultiyLevel = DificultyLevelEnum.Hard, ActiveGame = false },
                new Game { Id = 9, UserId = 1, ScoreId = 9, CurrentDificultiyLevel = DificultyLevelEnum.Easy, ActiveGame = false },
                new Game { Id = 10, UserId = 2, ScoreId = 10, CurrentDificultiyLevel = DificultyLevelEnum.Harder, ActiveGame = false },
                new Game { Id = 11, UserId = 2, ScoreId = 11, CurrentDificultiyLevel = DificultyLevelEnum.Hard, ActiveGame = false }
                );
        }
    }

}
