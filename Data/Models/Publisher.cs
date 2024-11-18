﻿using System.Collections.Generic;

namespace LIBRERIA_NCL.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion
        public List<Books> Books { get; set; }
    }
}