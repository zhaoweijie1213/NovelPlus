using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 新闻服务实现
/// </summary>
public class NewsService(INewsRepository repository) : INewsService
{
    private readonly INewsRepository _repository = repository;

    /// <inheritdoc/>
    public async Task<List<NewsEntity>> ListIndexNewsAsync()
    {
        var list = await _repository.ListAsync(new Dictionary<string, object>());
        return list.OrderByDescending(i => i.CreateTime).Take(2).ToList();
    }
}
