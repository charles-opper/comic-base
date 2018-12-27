using ComicBase.Core.Domain.Entities;
using ComicBase.Core.Tests.Mocks;
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
    public class ComicBaseEfSqlRepository_PublisherServiceTests
    {
        public ComicBaseEfSqlRepository_PublisherServiceTests()
        {
            _factory = new ComicBaseRepositoryFactory();
        }

        [TestMethod]
        public void GetActivePublishers()
        {
            var publishers = new List<Publisher>();

            var repo = _factory.GetRepository<Publisher>(MockConfiguration.ConnectionString);

            publishers.AddRange(repo.Get());

            Assert.IsTrue(publishers.Count() > 0);
        }

        IComicBaseRepositoryFactory _factory;
    }
}
