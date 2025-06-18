using System.Linq.Expressions;

namespace BuildingBlocks.SharedKernel.Repositories;

/// <summary>
/// 泛型仓储接口
/// </summary>
public interface IGenericRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// 根据ID获取实体
    /// </summary>
    Task<TEntity?> GetByIdAsync(long id);

    /// <summary>
    /// 添加实体
    /// </summary>
    Task AddAsync(TEntity entity);

    /// <summary>
    /// 根据条件查询
    /// </summary>
    Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> predicate);
}
