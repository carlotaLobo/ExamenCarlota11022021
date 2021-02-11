using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Models
{
    public class Cesta
    {
        public int IdPelicula { get; set; }
        public int Precio { get; set; }
        
        public Cesta(int idpelicula, int precio)
        {
            this.IdPelicula = idpelicula;
            this.Precio = precio;
        }
        public Cesta() : base() { }
    }
}
