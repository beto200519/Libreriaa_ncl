using System.Collections.Generic;
using System;
using LIBRERIA_NCL.Data.ViewModels;
using LIBRERIA_NCL.Data.Models;
using System.Linq;

namespace LIBRERIA_NCL.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un libro en BD
        public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Book.Add(_book);
            _context.SaveChanges();
        }
             //Metodo que nos permite obtener una lista de todos los libros en BD
             public List<Books> GetAllbks() => _context.Book.ToList();
             //Metodo que nos permite obtener el libro que estamos pidiendo en BD
             public Books GetBookById(int bookid) => _context.Book.FirstOrDefault(n => n.id == bookid);
             //Metodo que nos permite modificar un libro en la BD
             public Books UpdateBookById(int bookid, BookVM book)
             {
                 var _book = _context.Book.FirstOrDefault(n => n.id == bookid);
                 if (_book != null)
                 {
                     _book.Titulo = book.Titulo;
                     _book.Descripcion = book.Descripcion;
                     _book.IsRead = book.IsRead;
                     _book.DateRead = book.DateRead;
                     _book.Rate = book.Rate;
                     _book.Genero = book.Genero;
                     _book.Autor = book.Autor;
                     _book.CoverUrl = book.CoverUrl;

                     _context.SaveChanges();
                 }
                 return _book;
             }
        public void DeleteBookById(int bookid)
        {
            var _book = _context.Book.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _context.Book.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}