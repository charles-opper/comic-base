using ComicBase.Core.Domain.Exceptions;
using ComicBase.Core.Domain.Interfaces;
using ComicBase.EfSqlRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBase.EfSqlRepository.Repository
{
    internal class ComicBaseEfSqlRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        public ComicBaseEfSqlRepository(ComicBaseContext context)
        {
            _context = context;
        }
        
        public IEnumerable<T> Get()
        {
            return _context.Set<T>().Where(i => i.Active);
        }

        public async Task<T> GetAsync(int id)
        {
            var item = await _context.FindAsync<T>(id);
            if (item == null)
            {
                throw new EntityNotFoundException<T>(id);
            }

            return item;
        }

        public async Task<T> InsertAsync(T item)
        {
            item.Created = DateTime.Now;
            item.Updated = item.Created;
            item.Active = true;

            var inserted = await _context.AddAsync(item);
            await _context.SaveChangesAsync();

            return inserted.Entity;
        }

        public void Update(T item)
        {
            item.Updated = DateTime.Now;

            _context.Update(item);

            _context.SaveChangesAsync();
        }

        public void Remove(T item)
        {
            if (item.Active)
            {
                item.Active = false;
                item.Updated = DateTime.Now;

                _context.Update(item);

                _context.SaveChanges();
            }
        }

        public void Delete(T item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        private ComicBaseContext _context;
    }
}
