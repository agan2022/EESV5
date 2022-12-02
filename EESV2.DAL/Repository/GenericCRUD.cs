using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EESV2.DAL.Repository
{
    public class GenericCRUD<Entity> where Entity : class
    {
        private readonly DbContext _context;
        private DbSet<Entity> _table;

        public GenericCRUD(DbContext context)
        {
            _context = context;
            _table = _context.Set<Entity>();
        }


        public virtual void Create(Entity entity)
        {
            _table.Add(entity);
        }
        public virtual void Create(IEnumerable<Entity> entities)
        {
            _table.AddRange(entities);
        }

        public virtual void Update(Entity entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual Entity GetById(object id)
        {
            return _table.Find(id);
        }

        public virtual void Delete(Entity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _table.Attach(entity);
            }
            _table.Remove(entity);
        }

        public virtual void DeleteById(object id)
        {
            var entity = GetById(id);
            Delete(entity);
        }




        public bool IsExist(Expression<Func<Entity, bool>> predicate)
        {
            return _table.Any(predicate);
        }
        public async Task<bool> IsExistAsync(Expression<Func<Entity, bool>> predicate)
        {
            return await _table.AnyAsync(predicate);
        }
        public async Task<bool> IsExistAsync(Expression<Func<Entity, bool>> predicate,
                                            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> include = null)
        {
            IQueryable<Entity> query = _table;

            if (include != null)
            {
                query = include(query);
            }
            return await query.AnyAsync(predicate);

        }



        public virtual void DeleteByRang(IEnumerable<Entity> entities) => _table.RemoveRange(entities);





        public int Count(Expression<Func<Entity, bool>> predicate = null)
        {
            IQueryable<Entity> query = _table;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query.Count();
        }
        public decimal? Sum(Expression<Func<Entity,decimal?>> selector)
        {
            IQueryable<Entity> query = _table;
            return query.Sum(selector);
        }

        public IQueryable<Entity> Get(Expression<Func<Entity, bool>> predicate = null,
                                                  Func<IQueryable<Entity>, IOrderedQueryable<Entity>> orderBy = null,
                                                  Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> include = null,
                                                  bool disableTracking = true)
        {
            IQueryable<Entity> query = _table;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }

        }
    }
}
