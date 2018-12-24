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
    public class ComicBaseEfSqlRepository_PublisherTests
    {
        public ComicBaseEfSqlRepository_PublisherTests()
        {
            var repoFactory = new ComicBaseRepositoryFactory();
            _repo = repoFactory.GetRepository<Publisher>(MockConfiguration.ConnectionString);
        }

        [ClassCleanup]
        public static void CleanupIssueTests()
        {
            var repoFactory = new ComicBaseRepositoryFactory();
            var publisherRepo = repoFactory.GetRepository<Publisher>(MockConfiguration.ConnectionString);
            publisherRepo.Get().ToList().ForEach(p => publisherRepo.Delete(p));
        }

        [TestMethod]
        public void GetActivePublishers()
        {
            var publisher = new Publisher()
            {
                 Name = "Marvel",
                 SiteUrl = "http://www.marvel.com"
            };

            var inserted = _repo.InsertAsync(publisher).Result;

            var publishers = _repo.Get();

            Assert.IsTrue(publishers.Count() >= 1);
        }

        [TestMethod]
        public void GetPublisherById()
        {
            var publisher = new Publisher()
            {
                Name = "DC",
                SiteUrl = "http://www.dccomics.com"
            };

            var inserted = _repo.InsertAsync(publisher).Result;

            var thePublisher = _repo.GetAsync(inserted.Id.Value).Result;

            Assert.AreEqual(inserted.Id, thePublisher.Id);
        }

        [TestMethod]
        public void InsertIssue()
        {
            var publisher = new Publisher()
            {
                Name = "Marvel",
                SiteUrl = "http://www.marvel.com"
            };

            var inserted = _repo.InsertAsync(publisher).Result;

            Assert.IsTrue(inserted.Id.HasValue);
        }

        [TestMethod]
        public void UpdateIssue()
        {
            var publisher = new Publisher()
            {
                Name = "Marvel",
                SiteUrl = "http://www.marvel.com"
            };

            var inserted = _repo.InsertAsync(publisher).Result;

            const string expected = "http://www.marvelcomics.com";
            inserted.SiteUrl = expected;

            _repo.Update(inserted);

            var updated = _repo.GetAsync(inserted.Id.Value).Result;
            Assert.AreEqual(expected, updated.SiteUrl);
        }

        [TestMethod]
        public void RemoveIssue()
        {
            var publisher = new Publisher()
            {
                Name = "Marvel",
                SiteUrl = "http://www.marvel.com"
            };

            var inserted = _repo.InsertAsync(publisher).Result;

            _repo.Remove(inserted);

            Assert.AreEqual(false, inserted.Active);
        }

        [TestMethod]
        public void DeleteIssue()
        {
            var publisher = new Publisher()
            {
                Name = "IDW Comics",
                SiteUrl = "http://www.idwcomics.com"
            };
            var inserted = _repo.InsertAsync(publisher).Result;

            _repo.Delete(inserted);

            Type actualEx = null;
            var expectedEx = typeof(EntityNotFoundException<Publisher>);
            try
            {
                var _ = _repo.GetAsync(inserted.Id.Value).Result;
            }
            catch (AggregateException ae)
            {
                actualEx = ae.InnerException.GetType();
            }

            Assert.AreEqual(expectedEx, actualEx);
        }

        private IRepository<Publisher> _repo;
    }
}
