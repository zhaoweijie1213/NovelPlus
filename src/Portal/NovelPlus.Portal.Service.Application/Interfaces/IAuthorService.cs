using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 作者服务接口
/// </summary>
public interface IAuthorService : IScopeDependency
{
    /// <summary>
    /// 校验笔名是否存在
    /// </summary>
    Task<bool> CheckPenNameAsync(string penName);

    /// <summary>
    /// 查询作家信息
    /// </summary>
    Task<AuthorEntity?> QueryAuthorAsync(long userId);
}
