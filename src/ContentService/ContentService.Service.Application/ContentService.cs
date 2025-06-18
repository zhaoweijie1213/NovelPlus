using System.Collections.Generic;
using ContentService.Service.Domain.Entities;

namespace ContentService.Service.Application;

/// <summary>
/// 内容业务实现
/// </summary>
public class ContentService : IContentService
{
    /// <summary>
    /// 示例新闻列表
    /// </summary>
    private readonly List<News> _news = new()
    {
        new News { Id = 1, Title = "欢迎" }
    };

    /// <inheritdoc />
    public IEnumerable<News> GetAll() => _news;
}
