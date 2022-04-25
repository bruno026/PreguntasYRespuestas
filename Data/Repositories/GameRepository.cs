using Core.Data.Repositories;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(PreguntasDBContext context)
    : base(context) { }

        private PreguntasDBContext PreguntasContext
        {
            get { return Context as PreguntasDBContext; }
        }
        public override async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await PreguntasContext.Games.Include(game => game.Score).Include(game=>game.User).ToListAsync();
        }
    }
}
