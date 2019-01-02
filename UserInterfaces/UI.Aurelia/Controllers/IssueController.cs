using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBase.Core.Domain.Entities;
using ComicBase.EfSqlRepository.DataServices;
using ComicBase.EfSqlRepository.Interfaces;
using ComicBase.Spa.Infrastructure;
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
        [ProducesResponseType(404)]
        public async Task<ActionResult<Issue>> Get(int id)
        {
            var service = new IssueService(ConnectionString, _factory);

            var issue = await service.GetIssueAsync(id);

            if (issue == null)
            {
                return NotFound();
            }

            return issue;
        }

        // POST: api/Issue
        [HttpPost]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Issue>> Post([FromBody] Issue issue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = new IssueService(ConnectionString, _factory);

            await service.SaveIssueAsync(issue);
            
            return new CreatedAtActionResult(nameof(Get), "Issue", new { id = issue.Id }, issue);
        }

        // PUT: api/Issue/5
        [HttpPut("{id}")]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Issue>> Put(int id, [FromBody] Issue issue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = new IssueService(ConnectionString, _factory);

            return await service.SaveIssueAsync(issue);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Issue>> Delete(int id)
        {
            var service = new IssueService(ConnectionString, _factory);

            var issue = await service.GetIssueAsync(id);
            if (issue == null)
            {
                return NotFound();
            }

            service.RemoveIssue(issue);

            return issue;
        }

        private IComicBaseRepositoryFactory _factory;
    }
}
