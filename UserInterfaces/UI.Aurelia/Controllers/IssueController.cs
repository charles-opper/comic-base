using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBase.Core.Domain.Entities;
using ComicBase.EfSqlRepository.DataServices;
using ComicBase.EfSqlRepository.Interfaces;
using ComicBase.Spa.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ComicBase.Spa.Controllers
{
    [Route("api/issue")]
    public class IssueController : ApiControllerBase
    {
        public IssueController(IComicBaseRepositoryFactory factory, IConfiguration configuration, IOptions<AppConfig> options)
            : base(configuration, options)
        {
            _factory = factory;
        }

        // GET: api/Issue
        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
        {
            var service = new IssueService(ConnectionString, _factory);

            return await Task.Factory.StartNew(() => service.GetActiveIssues()); 
        }

        // GET: api/Issue/5
        [HttpGet("{id}")]
        public async Task<Issue> Get(int id)
        {
            var service = new IssueService(ConnectionString, _factory);

            return await service.GetIssueAsync(id);
        }

        // POST: api/Issue
        [HttpPost]
        public async Task<ActionResult<Issue>> Post([FromBody] Issue issue)
        {
            var service = new IssueService(ConnectionString, _factory);

            await service.SaveIssueAsync(issue);
            
            return new CreatedAtActionResult(nameof(Get), "Issue", new { id = issue.Id }, issue);
        }

        // PUT: api/Issue/5
        [HttpPut("{id}")]
        public async Task<Issue> Put(int id, [FromBody] Issue issue)
        {
            var service = new IssueService(ConnectionString, _factory);

            return await service.SaveIssueAsync(issue);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<Issue> Delete(int id)
        {
            var service = new IssueService(ConnectionString, _factory);

            var issue = await service.GetIssueAsync(id);
            service.RemoveIssue(issue);

            return issue;
        }

        private IComicBaseRepositoryFactory _factory;
    }
}
