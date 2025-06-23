using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 友情链接服务实现
/// </summary>
public class FriendLinkService(IFriendLinkRepository repository) : IFriendLinkService
{
    private readonly IFriendLinkRepository _repository = repository;

    /// <summary>
    /// 获取首页展示的友情链接
    /// </summary>
    /// <returns>链接列表</returns>
    public Task<List<FriendLinkEntity>> ListIndexLinkAsync() => _repository.ListIndexLinkAsync();
}
