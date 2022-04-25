using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreguntasYResupuestas.Controllers
{
    public class PlayController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewGameService _newGameService;

        public PlayController(ILogger<HomeController> logger, INewGameService newGameService)
        {
            _logger = logger;
            _newGameService = newGameService;
        }
        public async Task<IActionResult> Index(string userName)
        {
            await _newGameService.InitNewGame(new User() { UserName=userName });
            return View();
        }
    }
}
