using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApnaGhar.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApnaGhar.Base
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected AppDBContext AppDBContext;

        public ServiceBase(AppDBContext appDBContext)
        {
            AppDBContext = appDBContext;
        }

        public IQueryable<T> GetAll()
        {
            return AppDBContext.Set<T>();
        }

        public virtual async Task<ICollection<T>> GetAllAsyn()
        {

            return await AppDBContext.Set<T>().ToListAsync();
        }

        public virtual T Get(int id)
        {
            return AppDBContext.Set<T>().Find(id);
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await AppDBContext.Set<T>().FindAsync(id);
        }

        public virtual T Add(T t)
        {

            AppDBContext.Set<T>().Add(t);
            AppDBContext.SaveChanges();
            return t;
        }

        public virtual async Task<T> AddAsyn(T t)
        {
            AppDBContext.Set<T>().Add(t);
            await AppDBContext.SaveChangesAsync();
            return t;

        }

        public virtual T Find(Expression<Func<T, bool>> match)
        {
            return AppDBContext.Set<T>().SingleOrDefault(match);
        }

        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await AppDBContext.Set<T>().SingleOrDefaultAsync(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return AppDBContext.Set<T>().Where(match).ToList();
        }

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await AppDBContext.Set<T>().Where(match).ToListAsync();
        }

        public virtual void Delete(T entity)
        {
            AppDBContext.Set<T>().Remove(entity);
            AppDBContext.SaveChanges();
        }

        public virtual async Task<int> DeleteAsyn(T entity)
        {
            AppDBContext.Set<T>().Remove(entity);
            return await AppDBContext.SaveChangesAsync();
        }

        public virtual T Update(T t, object key)
        {
            if (t == null)
                return null;
            T exist = AppDBContext.Set<T>().Find(key);
            if (exist != null)
            {
                AppDBContext.Entry(exist).CurrentValues.SetValues(t);
                AppDBContext.SaveChanges();
            }
            return exist;
        }

        public virtual async Task<T> UpdateAsyn(T t, object key)
        {
            if (t == null)
                return null;
            T exist = await AppDBContext.Set<T>().FindAsync(key);
            if (exist != null)
            {
                AppDBContext.Entry(exist).CurrentValues.SetValues(t);
                await AppDBContext.SaveChangesAsync();
            }
            return exist;
        }

        public int Count()
        {
            return AppDBContext.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await AppDBContext.Set<T>().CountAsync();
        }

        public virtual void Save()
        {

            AppDBContext.SaveChanges();
        }

        public async virtual Task<int> SaveAsync()
        {
            return await AppDBContext.SaveChangesAsync();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = AppDBContext.Set<T>().Where(predicate);
            return query;
        }

        public virtual async Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate)
        {
            return await AppDBContext.Set<T>().Where(predicate).ToListAsync();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> queryable = GetAll();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {

                queryable = queryable.Include<T, object>(includeProperty);
            }

            return queryable;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    AppDBContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
