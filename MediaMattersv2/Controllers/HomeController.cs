using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMattersv2.Models.Albums;
using MediaMattersv2.Models.Books;
using MediaMattersv2.Models.Games;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaMattersv2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository bk;
        private readonly IAlbumRepository ab;
        private readonly IGameRepository ga;
        public HomeController(IBookRepository bookRepo, IAlbumRepository albumRepo, IGameRepository gameRepo)
        {
            bk = bookRepo;
            ab = albumRepo;
            ga = gameRepo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Album()
        {
            return View(ab.getAlbums());
        }
        public IActionResult Book()
        {
            return View(bk.getBooks());
        }
        public IActionResult Game()
        {
            return View(ga.getGames());
        }
    }
}
