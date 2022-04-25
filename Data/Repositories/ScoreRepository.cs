using Core.Models;
using Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(PreguntasDBContext context)
            : base(context) { }

        private PreguntasDBContext PreguntasContext
        {
            get { return Context as PreguntasDBContext; }
        }
    }
}
