using System;
using System.Collections.Generic;
using System.Linq;
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
        new News { Id = 1, CatId = 1, CatName = "公告", Title = "欢迎", Content = "欢迎加入" }
    };

    /// <inheritdoc />
    public IEnumerable<News> GetAll() => _news;

    /// <inheritdoc />
    public News? GetById(long id) => _news.FirstOrDefault(n => n.Id == id);

    /// <inheritdoc />
    public IEnumerable<News> List(IDictionary<string, object> filters) => _news;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _news.Count;

    /// <inheritdoc />
    public int Save(News news)
    {
        news.Id = _news.Max(n => n.Id) + 1;
        _news.Add(news);
        return 1;
    }

    /// <inheritdoc />
    public int Update(News news)
    {
        var index = _news.FindIndex(n => n.Id == news.Id);
        if (index == -1) return 0;
        _news[index] = news;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var news = _news.FirstOrDefault(n => n.Id == id);
        if (news == null) return 0;
        _news.Remove(news);
        return 1;
    }

    /// <inheritdoc />
    public int BatchRemove(long[] ids)
    {
        var removed = 0;
        foreach (var id in ids) removed += Remove(id);
        return removed;
    }

    /// <inheritdoc />
    public IDictionary<object, object> TableStat(DateTime minDate)
    {
        return new Dictionary<object, object>();
    }
}
