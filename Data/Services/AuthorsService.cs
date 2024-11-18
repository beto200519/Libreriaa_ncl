using LIBRERIA_NCL.Data.Models;
using LIBRERIA_NCL.Data.ViewModels;

namespace LIBRERIA_NCL.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un nuevo autor en BD
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName,

            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}