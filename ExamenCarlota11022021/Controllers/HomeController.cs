using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExamenCarlota11022021.Extensions;
using ExamenCarlota11022021.Models;
using ExamenCarlota11022021.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenCarlota11022021.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        ISession session => HttpContext.Session;
        public HomeController(IRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            session.SetString("algo", "algo");

            session.SetObject("CESTA", new List<Cesta>());

            String text = session.GetString("algo");



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
        public IActionResult GuardarCesta(int id)
        {

            List<Cesta> listacesta = session.GetObject<List<Cesta>>("CESTA");
            List<Cesta> cestita = new List<Cesta>();
            Cesta cestanueva;
            Cesta cestaantes;

            Pelicula peli = this.repo.FindPeliById(id);

            cestanueva = new Cesta();
            cestanueva.IdPelicula = peli.Id;
            cestanueva.Precio = peli.Precio;
            cestita.Add(cestanueva);

            if (listacesta != null)
            {
                foreach (Cesta c in listacesta)
                {
                    cestaantes = new Cesta();
                    cestaantes.Precio = c.Precio;
                    cestaantes.IdPelicula = c.IdPelicula;
                    if (c.IdPelicula != cestanueva.IdPelicula)
                    {
                        cestita.Add(cestaantes);
                    }
                }
            }
            session.SetObject("CESTA", cestita);
         
            return RedirectToAction("detallepeli", peli);

        }

        public IActionResult VerCesta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VerCesta(int[] id)
        {
            List<Cesta> listacesta = session.GetObject<List<Cesta>>("CESTA");
            List<Cesta> cestita = new List<Cesta>();
            Cesta cestanueva;

            if (listacesta != null)
            {
                foreach (Cesta c in listacesta)
                {
                    for (int i = 0; i < id.Length; i++)
                    {
                        if (c.IdPelicula == id[i])
                        {
                            cestanueva = new Cesta(c.IdPelicula, c.Precio);
                            cestita.Add(cestanueva);
                        }
                    }
                }
            }

            session.SetObject("CESTA", cestita);

            return View();
        }
    }
}
