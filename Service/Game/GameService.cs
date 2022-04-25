using Core.Data;
using Data;
using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GameService : IGameService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GameService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            var games = await _unitOfWork.GameRepository.GetAllAsync();
            return games;
        }

        public async Task<Game> GetById(int id)
        {
            var game = await _unitOfWork.GameRepository.GetByIdAsync(id);
            return game;
        }

        public async Task<int> NewGame (Game game)
        {
            await _unitOfWork.GameRepository.AddAsync(game);
            var result = await _unitOfWork.CommitAsync();
            return result;
        }
    }
}
