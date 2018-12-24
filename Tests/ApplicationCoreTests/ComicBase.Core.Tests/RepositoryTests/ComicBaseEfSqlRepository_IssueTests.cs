using ComicBase.Core.Domain.Entities;
using ComicBase.Core.Domain.Exceptions;
using ComicBase.Core.Domain.Interfaces;
using ComicBase.Core.Tests.Mocks;
using ComicBase.EfSqlRepository.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComicBase.Core.Tests.RepositoryTests
{
    [TestClass]
    public class ComicBaseEfSqlRepository_IssueTests
    {
        public ComicBaseEfSqlRepository_IssueTests()
        {
            var repoFactory = new ComicBaseRepositoryFactory();
            _repo = repoFactory.GetRepository<Issue>(MockConfiguration.ConnectionString);
        }

        [ClassInitialize]
        public static void InitializeIssueTests(TestContext testContext)
        {
            var repoFactory = new ComicBaseRepositoryFactory();
            var publisherRepo = repoFactory.GetRepository<Publisher>(MockConfiguration.ConnectionString);
            
            if (!publisherRepo.Get().Any() || _defaultPublisher == null)
            {
                _defaultPublisher = publisherRepo.InsertAsync(new Publisher() {
                    Name = "Marvel",
                    SiteUrl = "http://www.marvel.com"
                }).Result;
            }
        }

        [ClassCleanup]
        public static void CleanupIssueTests()
        {
            var repoFactory = new ComicBaseRepositoryFactory();

            var issuerRepo = repoFactory.GetRepository<Issue>(MockConfiguration.ConnectionString);
            issuerRepo.Get().ToList().ForEach(i => issuerRepo.Delete(i));

            var publisherRepo = repoFactory.GetRepository<Publisher>(MockConfiguration.ConnectionString);
            publisherRepo.Get().ToList().ForEach(p => publisherRepo.Delete(p));
        }

        [TestMethod]
        public void GetActiveIssues()
        {
            var issue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var inserted = _repo.InsertAsync(issue).Result;

            var issues = _repo.Get();

            Assert.IsTrue(issues.Count() == 1);
        }

        [TestMethod]
        public void GetIssueById()
        {
            var issue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var inserted = _repo.InsertAsync(issue).Result;

            var theIssue = _repo.GetAsync(inserted.Id.Value).Result;

            Assert.AreEqual(inserted.Id, theIssue.Id);
        }

        [TestMethod]
        public void InsertIssue()
        {
            var issue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var inserted = _repo.InsertAsync(issue).Result;

            Assert.IsTrue(inserted.Id.HasValue);
        }

        [TestMethod]
        public void UpdateIssue()
        {
            var issue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var inserted = _repo.InsertAsync(issue).Result;

            inserted.Year = 1963;

            _repo.Update(inserted);

            var updated = _repo.GetAsync(inserted.Id.Value).Result;
            Assert.AreEqual(1963, updated.Year);
        }

        [TestMethod]
        public void RemoveIssue()
        {
            var issue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var inserted = _repo.InsertAsync(issue).Result;

            _repo.Remove(inserted);

            Assert.AreEqual(false, inserted.Active);
        }

        [TestMethod]
        public void DeleteIssue()
        {
            var issue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };
            var insertedIssue = _repo.InsertAsync(issue).Result;

            _repo.Delete(insertedIssue);

            Type actualEx = null;
            var expectedEx = typeof(EntityNotFoundException<Issue>);
            try
            {
                var _ = _repo.GetAsync(insertedIssue.Id.Value).Result;
            }
            catch (AggregateException ae)
            {
                actualEx = ae.InnerException.GetType();
            }

            Assert.AreEqual(expectedEx, actualEx);
        }


        private static Publisher _defaultPublisher;
        private readonly IRepository<Issue> _repo;
    }
}
