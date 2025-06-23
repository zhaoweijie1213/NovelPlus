using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 角色数据权限服务实现
/// </summary>
public class RoleDataPermService(IRoleDataPermRepository repository, ILogger<RoleDataPermService> logger) : IRoleDataPermService
{
    private readonly IRoleDataPermRepository _repository = repository;
    private readonly ILogger<RoleDataPermService> _logger = logger;

    /// <inheritdoc/>
    public Task<SysRoleDataPermEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<SysRoleDataPermEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(SysRoleDataPermEntity entity)
    {
        _logger.LogInformation("Add role data perm roleId={RoleId}", entity.RoleId);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(SysRoleDataPermEntity entity)
    {
        _logger.LogInformation("Update role data perm {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
