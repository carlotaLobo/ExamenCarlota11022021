using ExamenCarlota11022021.Data;
using ExamenCarlota11022021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Repositories
{
    public class Repository : IRepository
    {
        Context context;
        public Repository(Context context)
        {
            this.context = context;
        }
        public List<Genero> FindAllGeneros()
        {
            return this.context.Generos.ToList();
        }

        public List<Pelicula> FindAllPelis()
        {
            return this.context.Pelicula.ToList();
        }

        public Genero FindGeneroById(int id)
        {
            return this.context.Generos.Find(id);
        }

        public List<Pelicula> FindPeliByGenero(int idgenero)
        {
            return (from data in this.context.Pelicula select data)
                .Where(z => z.Idgenero == idgenero).ToList();
        }

        public Pelicula FindPeliById(int id)
        {
            return this.context.Pelicula.Find(id);
        }

        public Genero InsertGenero(Genero genero)
        {
            throw new NotImplementedException();
        }

        public Pelicula InsertPelicula(Pelicula genero)
        {
            throw new NotImplementedException();
        }

        public Pelicula Update(Pelicula peli)
        {
            Pelicula pelicula= this.context.Pelicula.Update(peli).Entity;
            
            this.context.SaveChanges();
            return pelicula;


                }
    }
}
