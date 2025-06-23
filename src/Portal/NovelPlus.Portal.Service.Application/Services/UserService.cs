using Mapster;
using Microsoft.Extensions.Logging;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Input;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using QYQ.Base.SnowId.Interface;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 用户服务实现
/// </summary>
public class UserService(IUserRepository repository, ILogger<UserService> logger, ISnowIdGenerator idGenerator) : IUserService
{
    private readonly IUserRepository _repository = repository;
    private readonly ILogger<UserService> _logger = logger;
    private readonly ISnowIdGenerator _id = idGenerator;

    /// <inheritdoc/>
    public async Task<UserEntity?> RegisterAsync(UserEntity user)
    {
        if (await _repository.ExistsUserNameAsync(user.Username))
        {
            return null;
        }
        user.Id = _id.CreateId();
        user.NickName = user.Username;
        user.CreateTime = DateTime.Now;
        user.UpdateTime = user.CreateTime;
        await _repository.SaveAsync(user);
        _logger.LogInformation("Register user {Name}", user.Username);
        return user;
    }

    /// <inheritdoc/>
    public Task<UserEntity?> LoginAsync(UserEntity user)
    {
        return _repository.GetByNameAndPasswordAsync(user.Username, user.Password);
    }
}
