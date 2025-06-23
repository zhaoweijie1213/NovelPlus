using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 角色服务实现
/// </summary>
public class RoleService(IRoleRepository repository, ILogger<RoleService> logger) : IRoleService
{
    private readonly IRoleRepository _repository = repository;
    private readonly ILogger<RoleService> _logger = logger;

    /// <inheritdoc/>
    public Task<SysRoleEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<SysRoleEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(SysRoleEntity entity)
    {
        _logger.LogInformation("Add role {Name}", entity.RoleName);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(SysRoleEntity entity)
    {
        _logger.LogInformation("Update role {Id}", entity.RoleId);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
