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
    public class PublisherControllers : ControllerBase
    {
        private PublisherControllers _publisherControllers;

        public PublisherControllers(PublisherControllers publisherControllers)
        {
            _publisherControllers = publisherControllers;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publisherControllers.AddPublisher(publisher);
            return Ok();
        }

        [HttpGet("get-publisher-books-with-authors/{id}")]
        public IActionResult GetPublisherData(int id)
        {
            var _response = _publisherControllers.GetPublisherData(id);
            return Ok(_response);
        }

    }
}
