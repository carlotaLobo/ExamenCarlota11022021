using ExamenCarlota11022021.Data;
using ExamenCarlota11022021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Repositories
{
   public interface IRepository
    {

        Genero InsertGenero(Genero genero);
        List<Genero> FindAllGeneros();
        Genero FindGeneroById(int id);

        Pelicula InsertPelicula(Pelicula genero);
        List<Pelicula> FindAllPelis();
        Pelicula FindPeliById(int id);
        List<Pelicula> FindPeliByGenero(int idgenero);




    }
}
