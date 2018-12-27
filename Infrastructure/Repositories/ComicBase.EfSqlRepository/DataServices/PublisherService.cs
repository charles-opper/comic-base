using ComicBase.Core.Domain.Entities;
using ComicBase.EfSqlRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.EfSqlRepository.DataServices
{
    public class PublisherService
    {
        public PublisherService(string connectionString, IComicBaseRepositoryFactory factory)
        {
            _connectionString = connectionString;
            _factory = factory;
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            var repo = _factory.GetRepository<Publisher>(_connectionString);

            return repo.Get();
        }

        private IComicBaseRepositoryFactory _factory;
        private string _connectionString;
    }
}
