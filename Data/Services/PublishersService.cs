using LIBRERIA_NCL.Data.ViewModels;
using System.Linq;
using LIBRERIA_NCL.Data.Models;
using System;


namespace LIBRERIA_NCL.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar una nueva Editora a la BD
        public Publisher AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
            return _publisher;
        }
        public Publisher GetPublisherById(int id) => _context.Publishers.FirstOrDefault(x => x.Id == id);
        



        public PublisherWithBooksAndAuthorsVM GetPublisherData(int publisherId)
        {
            var _publisherData = _context.Publishers.Where(n => n.Id == publisherId).Select(n => new PublisherWithBooksAndAuthorsVM()
            {
                Name = n.Name,
                BookAuthors = n.Books.Select(n => new BookAuthorVM()
                {
                    BookName = n.Titulo,
                    BookAuthors = n.Book_Authors.Select(n => n.Author.FullName).ToList()
                }).ToList()
            }).FirstOrDefault();
            return _publisherData;
        }

        internal void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(n => n.Id == id);
            if (_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges();
            }
        }
    }
}