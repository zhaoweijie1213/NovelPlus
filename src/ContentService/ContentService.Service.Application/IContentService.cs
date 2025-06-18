using System.Collections.Generic;
using ContentService.Service.Domain.Entities;

namespace ContentService.Service.Application;

/// <summary>
/// 内容业务接口
/// </summary>
public interface IContentService
{
    /// <summary>
    /// 获取新闻列表
    /// </summary>
    IEnumerable<News> GetAll();
}
