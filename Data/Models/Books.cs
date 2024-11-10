using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace LIBRERIA_NCL.Data.Models
{
    public class Books

    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public string Author { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Propiedades de navegacion(En esta parte es donde "Mapeamos")
        public int PublisherId { get; set; }
        public System.Security.Policy.Publisher Publisher { get; set; }

        public List<Book_Author> Book_Authors { get; set; }
    }
}