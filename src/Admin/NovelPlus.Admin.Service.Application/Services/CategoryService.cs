using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 分类服务实现，用于管理小说分类的增删改查操作
/// </summary>
public class CategoryService(ICategoryRepository repository, ILogger<CategoryService> logger) : ICategoryService
{
    /// <summary>
    /// 分类仓储
    /// </summary>
    private readonly ICategoryRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<CategoryService> _logger = logger;

    /// <inheritdoc/>
    public Task<CategoryEntity?> GetAsync(int id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<CategoryEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(CategoryEntity category)
    {
        category.CreateTime = DateTime.UtcNow;
        _logger.LogInformation("Add category: {Name}", category.Name);
        return _repository.SaveAsync(category);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(CategoryEntity category)
    {
        category.UpdateTime = DateTime.UtcNow;
        _logger.LogInformation("Update category: {Id}", category.Id);
        return _repository.UpdateAsync(category);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(int id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(int[] ids) => _repository.BatchRemoveAsync(ids);
}
