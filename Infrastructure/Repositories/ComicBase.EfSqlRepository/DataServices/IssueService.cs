using ComicBase.Core.Domain.Entities;
using ComicBase.Core.Domain.Interfaces;
using ComicBase.EfSqlRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBase.EfSqlRepository.DataServices
{
    /// <summary>
    /// Data service class for CRUD operations with issue entities.
    /// </summary>
    public class IssueService
    {
        public IssueService(string connectionString, IComicBaseRepositoryFactory factory)
        {
            _connectionString = connectionString;
            _factory = factory;
        }

        public async Task<Issue> GetIssueAsync(int id)
        {
            var publisherRepo = _factory.GetRepository<Publisher>(_connectionString);
            var issueRepo = _factory.GetRepository<Issue>(_connectionString);

            var issue = await issueRepo.GetAsync(id);
            issue.Publisher = await publisherRepo.GetAsync(issue.PublisherId);

            return issue;
        }

        public IEnumerable<Issue> GetActiveIssues()
        {
            var issues = new List<Issue>();

            var publisherRepo = _factory.GetRepository<Publisher>(_connectionString);
            var issueRepo = _factory.GetRepository<Issue>(_connectionString);

            issues.AddRange(issueRepo.Get().Where(i => i.Active));
            issues.ForEach(i => i.Publisher = publisherRepo.GetAsync(i.PublisherId).Result);

            return issues;
        }

        public async Task<Issue> SaveIssueAsync(Issue issue)
        {
            var issueRepo = _factory.GetRepository<Issue>(_connectionString);
            
            if (issue.Id.HasValue)
            {
                issueRepo.Update(issue);
            }
            else
            {
                await issueRepo.InsertAsync(issue);
            }

            var publisherRepo = _factory.GetRepository<Publisher>(_connectionString);
            issue.Publisher = publisherRepo.GetAsync(issue.PublisherId).Result;

            return issue;
        }

        public void RemoveIssue(Issue issue)
        {
            var issueRepo = _factory.GetRepository<Issue>(_connectionString);

            if (issue.Active)
            {
                issueRepo.Remove(issue);
            }
        }


        private IComicBaseRepositoryFactory _factory;
        private string _connectionString;
    }
}
