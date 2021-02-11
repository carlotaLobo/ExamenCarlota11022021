using ExamenCarlota11022021.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options) { }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
    }
}
