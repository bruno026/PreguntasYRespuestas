using Core.Data.Repositories;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(PreguntasDBContext context)
            : base(context) { }

        private PreguntasDBContext PreguntasContext
        {
            get { return Context as PreguntasDBContext; }
        }
    }   
}
