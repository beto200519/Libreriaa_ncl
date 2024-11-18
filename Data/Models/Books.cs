using System;
using System.Collections.Generic;
using System.Security.Policy;
using Microsoft.VisualBasic;
using LIBRERIA_NCL.Data.ViewModels;

namespace LIBRERIA_NCL.Data.Models
{
    public class Books
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Propiedades de navegacion(En esta parte es donde "Mapeamos")
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Book_Author> Book_Authors { get; set; }

    }
}