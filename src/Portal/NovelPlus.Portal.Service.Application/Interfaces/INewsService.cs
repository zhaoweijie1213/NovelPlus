using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 新闻服务接口
/// </summary>
public interface INewsService
{
    /// <summary>
    /// 查询首页新闻
    /// </summary>
    Task<List<NewsEntity>> ListIndexNewsAsync();
}
