using NovelPlus.Portal.Service.Application.Output;
using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 小说服务接口
/// </summary>
public interface IBookService : IScopeDependency
{
    /// <summary>
    /// 查询首页小说设置
    /// </summary>
    Task<Dictionary<byte, List<BookSettingOutput>>> ListBookSettingAsync();

    /// <summary>
    /// 查询首页点击榜单
    /// </summary>
    Task<List<BookEntity>> ListClickRankAsync();
}
