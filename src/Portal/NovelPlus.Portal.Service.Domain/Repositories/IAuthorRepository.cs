using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 作家仓储接口
/// </summary>
public interface IAuthorRepository : ITransientDependency
{
    /// <summary>
    /// 判断笔名是否存在
    /// </summary>
    Task<bool> ExistsPenNameAsync(string penName);

    /// <summary>
    /// 根据用户ID查询作家信息
    /// </summary>
    Task<AuthorEntity?> QueryAuthorAsync(long userId);
}
