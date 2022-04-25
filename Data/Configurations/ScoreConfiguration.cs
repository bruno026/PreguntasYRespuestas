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
    public class ScoreConfiguration : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.HasKey(score => new { score.Id, score.GameId });
            builder.HasOne(score => score.Game).WithOne(game => game.Score).IsRequired();
            builder.HasData(
                new Score { Id = 1,  GameId = 1,  Points = 1},
                new Score { Id = 2,  GameId = 2,  Points = 1},
                new Score { Id = 3,  GameId = 3,  Points = 0},
                new Score { Id = 4,  GameId = 4,  Points = 0},
                new Score { Id = 5,  GameId = 5,  Points = 4},
                new Score { Id = 6,  GameId = 6,  Points = 1},
                new Score { Id = 7,  GameId = 7,  Points = 0},
                new Score { Id = 8,  GameId = 8,  Points = 2},
                new Score { Id = 9,  GameId = 9,  Points = 0},
                new Score { Id = 10, GameId = 10, Points = 3},
                new Score { Id = 11, GameId = 11, Points = 2}
                );
        }

    }
}
