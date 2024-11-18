using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LIBRERIA_NCL.Data.Services;
using LIBRERIA_NCL.Data.ViewModels;
using System.Collections.Generic;

namespace LIBRERIA_NCL.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Propiedades de navegacion
        public List<Book_Author> Book_Authors { get; set; }
    }
}