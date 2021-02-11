using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Controllers
{
    public class PeliculasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
    }
}
