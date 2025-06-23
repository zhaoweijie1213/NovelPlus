using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 作家邀请码服务实现
/// </summary>
public class AuthorCodeService(IAuthorCodeRepository repository, ILogger<AuthorCodeService> logger) : IAuthorCodeService
{
    private readonly IAuthorCodeRepository _repository = repository;
    private readonly ILogger<AuthorCodeService> _logger = logger;

    /// <inheritdoc/>
    public Task<AuthorCodeEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<AuthorCodeEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(AuthorCodeEntity authorCode)
    {
        _logger.LogInformation("Add author code: {Code}", authorCode.InviteCode);
        return _repository.SaveAsync(authorCode);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(AuthorCodeEntity authorCode)
    {
        _logger.LogInformation("Update author code: {Id}", authorCode.Id);
        return _repository.UpdateAsync(authorCode);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
