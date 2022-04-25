using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class HighScoreService : IHighScoreService
    {
        private readonly IGameService _gameService;
        public HighScoreService(IGameService gameService)
        {
            this._gameService = gameService;
        }

        public async Task<IEnumerable<Game>> GetBestRankedGames(int nrOfGames)
        {
            return (await _gameService.GetAll()).OrderByDescending(game => game.Score.Points).Take(nrOfGames);
        }
    }
}
