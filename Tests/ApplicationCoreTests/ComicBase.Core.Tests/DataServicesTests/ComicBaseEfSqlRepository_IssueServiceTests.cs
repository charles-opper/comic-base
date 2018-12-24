using ComicBase.Core.Domain.Entities;
using ComicBase.Core.Tests.Mocks;
using ComicBase.EfSqlRepository.DataServices;
using ComicBase.EfSqlRepository.Interfaces;
using ComicBase.EfSqlRepository.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComicBase.Core.Tests.DataServicesTests
{
    [TestClass]
    public class ComicBaseEfSqlRepository_IssueServiceTests
    {
        public ComicBaseEfSqlRepository_IssueServiceTests()
        {
            _factory = new ComicBaseRepositoryFactory();
        }

        [ClassInitialize]
        public static void InitializeIssueTests(TestContext testContext)
        {
            var repoFactory = new ComicBaseRepositoryFactory();
            var publisherRepo = repoFactory.GetRepository<Publisher>(MockConfiguration.ConnectionString);

            if (!publisherRepo.Get().Any() || _defaultPublisher == null)
            {
                _defaultPublisher = publisherRepo.InsertAsync(new Publisher()
                {
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
            var service = new IssueService(MockConfiguration.ConnectionString, _factory);

            var issues = service.GetIssues();

            Assert.IsTrue(issues.Count() >= 0);
            Assert.IsTrue(issues.All(i => i.Publisher != null && i.Publisher.Id == i.PublisherId));
        }

        [TestMethod]
        public void GetActiveIssueById()
        {
            var service = new IssueService(MockConfiguration.ConnectionString, _factory);

            var newIssue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var savedIssue = service.SaveIssueAsync(newIssue).Result;

            var issue = service.GetIssueAsync(savedIssue.Id.Value).Result;

            Assert.AreEqual(savedIssue.Id, issue.Id);
            Assert.IsTrue(savedIssue.Publisher != null && savedIssue.PublisherId == savedIssue.Publisher.Id);
        }

        [TestMethod]
        public void SaveNewIssue()
        {
            var service = new IssueService(MockConfiguration.ConnectionString, _factory);

            var newIssue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var savedIssue = service.SaveIssueAsync(newIssue).Result;

            Assert.IsTrue(savedIssue.Id.HasValue);
            Assert.IsTrue(savedIssue.Active);
        }

        [TestMethod]
        public void UpdateExistingIssue()
        {
            var service = new IssueService(MockConfiguration.ConnectionString, _factory);

            var newIssue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var savedIssue = service.SaveIssueAsync(newIssue).Result;

            var issue = service.GetIssueAsync(savedIssue.Id.Value).Result;
            issue.Year = 1964;
            savedIssue = service.SaveIssueAsync(issue).Result;

            Assert.AreEqual(1964, savedIssue.Year);
        }

        [TestMethod]
        public void RemoveIssue()
        {
            var service = new IssueService(MockConfiguration.ConnectionString, _factory);

            var newIssue = new Issue()
            {
                Title = "Avengers",
                Volume = 1,
                IssueNumber = 1,
                Year = 1963,
                PublisherId = _defaultPublisher.Id.Value
            };

            var savedIssue = service.SaveIssueAsync(newIssue).Result;

            service.RemoveIssue(savedIssue);

            Assert.AreEqual(false, savedIssue.Active);
        }

        IComicBaseRepositoryFactory _factory;
        private static Publisher _defaultPublisher;
    }
}
