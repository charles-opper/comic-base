using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBase.Core.Domain.Entities;
using ComicBase.EfSqlRepository.DataServices;
using ComicBase.EfSqlRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ComicBase.Spa.Controllers
{
    [Route("api/publisher")]
    public class PublisherController : ApiControllerBase
    {
        public PublisherController(IComicBaseRepositoryFactory factory, IConfiguration config)
            : base(config)
        {
            _factory = factory;
        }

        // GET: api/Publisher
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            var service = new PublisherService(ConnectionString, _factory);

            return service.GetPublishers();
        }

        // GET: api/Publisher/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Publisher
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Publisher/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private IComicBaseRepositoryFactory _factory;
    }
}
