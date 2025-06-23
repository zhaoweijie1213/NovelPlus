using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 会话服务实现
/// </summary>
public class SessionService(ISysUserRepository repository, ILogger<SessionService> logger) : ISessionService
{
    private readonly ISysUserRepository _repository = repository;
    private readonly ILogger<SessionService> _logger = logger;

    /// <inheritdoc/>
    public Task<List<SysUserEntity>> ListOnlineUsersAsync() => _repository.ListAsync(new Dictionary<string, object>());

    /// <inheritdoc/>
    public Task<bool> ForceLogoutAsync(string sessionId)
    {
        _logger.LogInformation("Force logout session {SessionId}", sessionId);
        return Task.FromResult(true);
    }
}
