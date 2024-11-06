using libreria_JAGS.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace libreria_JAGS.Data.Models.Services
{
    public class BooksService
    {

        private AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
        } 
        //Metodo que nos permite agregar un nuevo libro en la db
        public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripccion = book.Descripccion,
                IsRead = book.IsRead,
                DataRead = book.DataRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        //Metodo que nos permite listar todos los libros de la db
        public List<Books> GetAllBks()=> _context.Books.ToList();
        //Metodo que nos permite obtener un libro por id de la db
        public Books GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);

        //Metodo que nos permite modificar un libro de la db
        public Books UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if(_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripccion = book.Descripccion;
                _book.IsRead = book.IsRead;
                _book.DataRead = book.DataRead;
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
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if(_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
