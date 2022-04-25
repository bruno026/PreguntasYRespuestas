using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PreguntasYResupuestas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHighScoreService _highScoreService;

        public HomeController(ILogger<HomeController> logger, IHighScoreService highScoreService )
        {
            _logger = logger;
            _highScoreService = highScoreService;
        }

        public async Task<IActionResult> Index()                                                                    
        {
            ViewBag.Games = await _highScoreService.GetBestRankedGames(10);
            return View();
        }

        public IActionResult HowToPlay()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewGame(User user)
        {
            if(!(string.IsNullOrWhiteSpace(user.UserName)))
                return RedirectToAction("Index", "Play",new { userName = user.UserName });
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
