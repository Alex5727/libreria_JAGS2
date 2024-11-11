using libreria_JAGS.Data.Models;
using libreria_JAGS.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libreria_JAGS.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;

        }

        //Metodo que nos permite agregar un nuevo libro en la db
        internal void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
