using ComicBase.Core.Domain.Interfaces;
using ComicBase.EfSqlRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.EfSqlRepository.Repository
{
    public class ComicBaseRepositoryFactory : IComicBaseRepositoryFactory
    {
        public IRepository<T> GetRepository<T>(string connectionString) where T : class, IEntity, new()
        {
            
            return new ComicBaseEfSqlRepository<T>(new ComicBaseContext(connectionString));
        }
    }
}
