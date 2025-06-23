using Microsoft.Extensions.Logging;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 作者服务实现
/// </summary>
public class AuthorService(IAuthorRepository repository, ILogger<AuthorService> logger) : IAuthorService
{
    private readonly IAuthorRepository _repository = repository;
    private readonly ILogger<AuthorService> _logger = logger;

    /// <inheritdoc/>
    public Task<bool> CheckPenNameAsync(string penName) => _repository.ExistsPenNameAsync(penName);

    /// <inheritdoc/>
    public Task<AuthorEntity?> QueryAuthorAsync(long userId) => _repository.QueryAuthorAsync(userId);
}
