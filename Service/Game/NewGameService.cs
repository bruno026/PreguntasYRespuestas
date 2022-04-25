using Core.Data;
using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class NewGameService : INewGameService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        public NewGameService(IUnitOfWork unitOfWork, IUserService userService)
        {
            this._unitOfWork = unitOfWork;
            this._userService = userService;
        }

        public async Task<int> InitNewGame(User user)
        {
            return await _userService.CreateUser(user);
            //Get categorias
            //Randomizar categorias
            //Crear juego & llamar a PlayServices
        }
    }
}
