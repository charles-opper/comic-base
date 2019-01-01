using ComicBase.Core.Domain.Interfaces;
using ComicBase.EfSqlRepository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.EfSqlRepository.Interfaces
{
    /// <summary>
    /// Generic repository interface required for EfSqlRepository dependencies.
    /// </summary>
    public interface IComicBaseRepositoryFactory
    {
        IRepository<T> GetRepository<T>(string connectionString) where T : class, IEntity, new();
    }
}
