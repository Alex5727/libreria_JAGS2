using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libreria_JAGS.Data.Models;

namespace libreria_JAGS.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
      
        //Propiedades de navegacion

       
        public List<Book_Author> Book_Authors { get; set; }



    }
}
