using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<T> GetAsync(object id);

        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> Query();

        Task InsertAsync(T entity);

        Task InsertAsync(IEnumerable<T> entities);

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);

        void Update(T entity);

        Task<int> SaveAsync();
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        protected DbContext DbContext { get; set; }

        public BaseRepository(DbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public async Task<T> GetAsync(object id)
        {
            return await DbContext.FindAsync<T>(id);
        }

        public async Task InsertAsync(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            await DbContext.Set<T>().AddRangeAsync(entities);
        }

        public IQueryable<T> Query()
        {
            return DbContext.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            DbContext.Set<T>().RemoveRange(entities);
        }

        public async Task<int> SaveAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        protected DbContext _appContext
        {
            get { return DbContext; }
        }

        
    }
}
