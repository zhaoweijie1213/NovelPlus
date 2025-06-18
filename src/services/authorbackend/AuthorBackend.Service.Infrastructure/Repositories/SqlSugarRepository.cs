using BuildingBlocks.SharedKernel.Repositories;
using SqlSugar;

namespace AuthorBackend.Service.Infrastructure.Repositories;

/// <summary>
/// SqlSugar泛型仓储实现
/// </summary>
public class SqlSugarRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
{
    private readonly ISqlSugarClient _db;

    /// <summary>
    /// 构造函数
    /// </summary>
    public SqlSugarRepository(ISqlSugarClient db)
    {
        _db = db;
    }

    /// <inheritdoc />
    public Task<TEntity?> GetByIdAsync(long id)
    {
        return _db.Queryable<TEntity>().InSingleAsync(id);
    }

    /// <inheritdoc />
    public Task AddAsync(TEntity entity)
    {
        return _db.Insertable(entity).ExecuteCommandAsync();
    }

    /// <inheritdoc />
    public Task<IEnumerable<TEntity>> QueryAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
    {
        return Task.FromResult(_db.Queryable<TEntity>().Where(predicate).AsEnumerable());
    }
}
