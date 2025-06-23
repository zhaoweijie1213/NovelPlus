using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 小说设置服务实现，用于管理小说相关设置的增删改查操作
/// </summary>
public class BookSettingService(IBookSettingRepository repository, ILogger<BookSettingService> logger) : IBookSettingService
{
    /// <summary>
    /// 小说设置仓储
    /// </summary>
    private readonly IBookSettingRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<BookSettingService> _logger = logger;

    /// <inheritdoc/>
    public Task<BookSettingEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<BookSettingEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(BookSettingEntity setting)
    {
        _logger.LogInformation("Add book setting for {BookId}", setting.BookId);
        return _repository.SaveAsync(setting);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(BookSettingEntity setting)
    {
        _logger.LogInformation("Update book setting {Id}", setting.Id);
        return _repository.UpdateAsync(setting);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
