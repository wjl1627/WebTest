using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DapperDao
{   
    /// <summary>
    /// 实体仓储模型的数据标准操作
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <typeparam name="TKey">主键类型</typeparam>
    public interface IRepositoryService<TEntity> : IDependency where TEntity : class
    {
        TEntity FirstOfDefault(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(Expression<Func<TEntity, bool>> predicate);
    }
}
