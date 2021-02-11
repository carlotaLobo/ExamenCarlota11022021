using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenCarlota11022021.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.FindAllPelis());
        }
        public IActionResult ListarPelisGenero(int id)
        {
            return View(this.repo.FindPeliByGenero(id));
        }
        public IActionResult DetallePeli(int id)
        {
            return View(this.repo.FindPeliById(id));
        }
    }
}
