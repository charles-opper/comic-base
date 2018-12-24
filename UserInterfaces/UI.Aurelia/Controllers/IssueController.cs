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
    [Route("api/[controller]")]
    public class IssueController : ApiControllerBase
    {
        public IssueController(IComicBaseRepositoryFactory factory, IConfiguration configuration)
            : base(configuration)
        {
            _factory = factory;
        }

        // GET: api/Issue
        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
        {
            var service = new IssueService(ConnectionString, _factory);

            return await Task.Factory.StartNew(() => service.GetIssues()); 
        }

        // GET: api/Issue/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Issue
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Issue/5
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
