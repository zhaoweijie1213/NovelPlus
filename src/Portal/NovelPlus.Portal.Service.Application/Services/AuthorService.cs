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

    /// <summary>
    /// 校验笔名是否重复
    /// </summary>
    /// <param name="penName">笔名</param>
    /// <returns>存在则返回 true</returns>
    public Task<bool> CheckPenNameAsync(string penName) => _repository.ExistsPenNameAsync(penName);

    /// <summary>
    /// 根据用户ID查询作家信息
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <returns>作家实体或 null</returns>
    public Task<AuthorEntity?> QueryAuthorAsync(long userId) => _repository.QueryAuthorAsync(userId);
}
