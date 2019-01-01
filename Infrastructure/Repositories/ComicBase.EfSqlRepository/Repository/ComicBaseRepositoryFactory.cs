using ComicBase.Core.Domain.Interfaces;
using ComicBase.EfSqlRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.EfSqlRepository.Repository
{
    /// <summary>
    /// Generic repository factory implementation that can create a repository for any entity type T.
    /// </summary>
    public class ComicBaseRepositoryFactory : IComicBaseRepositoryFactory
    {
        /// <summary>
        /// Get a repository for a specified entity type T.
        /// </summary>
        /// <typeparam name="T">The entity object type.</typeparam>
        /// <param name="connectionString">A connection string for the repository.</param>
        /// <returns>A generic repository object.</returns>
        /// <exception cref="ArgumentException">Thrown when connection string not provided.</exception>
        public IRepository<T> GetRepository<T>(string connectionString) where T : class, IEntity, new()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Missing required connection string for repository.", "connectionString");
            }

            return new ComicBaseEfSqlRepository<T>(new ComicBaseContext(connectionString));
        }
    }
}
