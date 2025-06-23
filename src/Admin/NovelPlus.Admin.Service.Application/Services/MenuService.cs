using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 菜单服务实现
/// </summary>
public class MenuService(IMenuRepository repository, ILogger<MenuService> logger) : IMenuService
{
    private readonly IMenuRepository _repository = repository;
    private readonly ILogger<MenuService> _logger = logger;

    /// <inheritdoc/>
    public Task<SysMenuEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<SysMenuEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(SysMenuEntity entity)
    {
        _logger.LogInformation("Add menu {Name}", entity.Name);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(SysMenuEntity entity)
    {
        _logger.LogInformation("Update menu {Id}", entity.MenuId);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
