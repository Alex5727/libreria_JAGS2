using libreria_JAGS.Data.Services;
using libreria_JAGS.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libreria_JAGS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsControllers : ControllerBase
    {
        private AuthorsService _authorsServices;

        public AuthorsControllers(AuthorsService authorsServices)
        {
            _authorsServices = authorsServices;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsServices.AddAuthor(author);
            return Ok();
        }

    }
}
