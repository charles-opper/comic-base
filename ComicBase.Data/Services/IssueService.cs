using ComicBase.Core.Domain.Entities;
using ComicBase.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Data.Services
{
    public class IssueService
    {
        public IssueService(IRepository<Issue> repo)
        {
            _repo = repo;
        }

        public Issue GetIssue(int id)
        {

        }

        public IEnumerable<Issue> GetIssues()
        {

        }

        public void SaveIssue(Issue issue)
        {

        }

        public void DeleteIssue(Issue issue)
        {

        }


        private IComicBaseRepository<Issue> _repo;
    }
}
