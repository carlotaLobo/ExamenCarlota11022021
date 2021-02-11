using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        [Column("idgenero")]
        public int Id { get; set; }
        [Column("genero")]
        public String Generos { get; set; }
    }
}
