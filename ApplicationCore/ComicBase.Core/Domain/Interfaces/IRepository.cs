using ComicBase.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComicBase.Core.Domain.Interfaces
{
    /// <summary>
    /// Basic generic repository for any given entity type T.
    /// </summary>
    /// <typeparam name="T">The entity object type.</typeparam>
    public interface IRepository<T> where T : class, IEntity, new()
    {
        IEnumerable<T> Get();

        Task<T> GetAsync(int id);

        Task<T> InsertAsync(T item);

        void Update(T item);
        
        void Remove(T item);

        void Delete(T item);
    }
}
