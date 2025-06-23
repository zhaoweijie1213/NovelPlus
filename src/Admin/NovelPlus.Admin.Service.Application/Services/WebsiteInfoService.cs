using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 网站信息服务实现
/// </summary>
public class WebsiteInfoService(IWebsiteInfoRepository repository, ILogger<WebsiteInfoService> logger) : IWebsiteInfoService
{
    private readonly IWebsiteInfoRepository _repository = repository;
    private readonly ILogger<WebsiteInfoService> _logger = logger;

    /// <inheritdoc/>
    public Task<WebsiteInfoEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<WebsiteInfoEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(WebsiteInfoEntity entity)
    {
        _logger.LogInformation("Add website info {Name}", entity.Name);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(WebsiteInfoEntity entity)
    {
        _logger.LogInformation("Update website info {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
