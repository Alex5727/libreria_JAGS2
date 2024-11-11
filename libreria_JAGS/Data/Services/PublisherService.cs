using libreria_JAGS.Data.Models;
using libreria_JAGS.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libreria_JAGS.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;

        public PublisherService(AppDbContext context)
        {
            _context = context;

        }

        //Metodo que nos permite agregar una nueva editora  en la db
        internal void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
