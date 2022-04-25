using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IGameService
    {
        Task<IEnumerable<Game>> GetAll();
        Task<Game> GetById(int id);
        Task<int> NewGame(Game game); 
    }
}
