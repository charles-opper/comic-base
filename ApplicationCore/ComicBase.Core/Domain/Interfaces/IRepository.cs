using ComicBase.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComicBase.Core.Domain.Interfaces
{
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
