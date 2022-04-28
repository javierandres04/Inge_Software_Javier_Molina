using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            SongModel myFavoriteSong = new SongModel
            {
                Nombre = "Don't Stop Me Now",
                Artista = "Queen",
                Album = "Jazz",
                Genero = "pop rock, piano rock",
                FechaEstreno = new DateTime(1979, 01, 05)
            };
            return View(myFavoriteSong);
        }
    }
}
