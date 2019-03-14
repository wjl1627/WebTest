using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DapperDao
{
    public class RepositoryServiceImpl<TEntity> : IRepositoryService<TEntity> where TEntity : class
    {
        public bool Delete(Expression<Func<TEntity, bool>> predicate)
        {
            Console.WriteLine("this is a Delete impl");
            return true;
        }

        public TEntity FirstOfDefault(Expression<Func<TEntity, bool>> predicate)
        {
            Console.WriteLine("this is a FirstOfDefault impl");
            return default(TEntity); 
        }

        public IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate)
        {
            Console.WriteLine("this is a GetEntities impl");
            return new List<TEntity>();
        }

        public TEntity Insert(TEntity entity)
        {
            Console.WriteLine("this is a Insert impl");
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            Console.WriteLine("this is a Update impl");
            return entity;
        }
    }
}
