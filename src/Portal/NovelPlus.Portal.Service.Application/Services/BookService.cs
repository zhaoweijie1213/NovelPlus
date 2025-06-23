using Mapster;
using Microsoft.Extensions.Logging;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Output;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 小说服务实现
/// </summary>
public class BookService(IBookRepository bookRepository, IBookSettingRepository settingRepository, ILogger<BookService> logger) : IBookService
{
    private readonly IBookRepository _bookRepository = bookRepository;
    private readonly IBookSettingRepository _settingRepository = settingRepository;
    private readonly ILogger<BookService> _logger = logger;

    /// <summary>
    /// 获取首页展示的小说设置
    /// </summary>
    /// <returns>按类型分组的小说设置列表</returns>
    public async Task<Dictionary<byte, List<BookSettingOutput>>> ListBookSettingAsync()
    {
        var list = await _settingRepository.ListVoAsync();
        var output = list.Adapt<List<BookSettingOutput>>();
        return output.GroupBy(i => i.Type ?? 0).ToDictionary(g => g.Key, g => g.ToList());
    }

    /// <summary>
    /// 获取点击量排行榜
    /// </summary>
    /// <returns>前十名的小说列表</returns>
    public async Task<List<BookEntity>> ListClickRankAsync()
    {
        var list = await _bookRepository.SearchByPageAsync(new Dictionary<string, object> { { "sort", "visit_count" } });
        return list.OrderByDescending(i => i.VisitCount).Take(10).ToList();
    }
}
