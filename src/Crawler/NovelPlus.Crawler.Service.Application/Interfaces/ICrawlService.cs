using NovelPlus.Crawler.Service.Application.Input;
using NovelPlus.Crawler.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Crawler.Service.Application.Interfaces;

/// <summary>
/// 爬虫服务接口
/// </summary>
public interface ICrawlService : IScopeDependency
{
    /// <summary>
    /// 新增爬虫源
    /// </summary>
    Task AddCrawlSourceAsync(CrawlSourceInput source);

    /// <summary>
    /// 修改爬虫源
    /// </summary>
    Task UpdateCrawlSourceAsync(CrawlSourceInput source);

    /// <summary>
    /// 爬虫源分页列表
    /// </summary>
    Task<List<CrawlSourceEntity>> ListCrawlByPageAsync(int page, int pageSize);

    /// <summary>
    /// 开启或停止爬虫
    /// </summary>
    Task OpenOrCloseCrawlAsync(int sourceId, byte sourceStatus);

    /// <summary>
    /// 更新爬虫状态
    /// </summary>
    Task UpdateCrawlSourceStatusAsync(int sourceId, byte sourceStatus);

    /// <summary>
    /// 采集并保存小说
    /// </summary>
    Task<bool> ParseBookAndSaveAsync(int catId, RuleBeanInput ruleBean, int sourceId, string bookId);

    /// <summary>
    /// 根据状态查询爬虫源
    /// </summary>
    Task<List<CrawlSourceEntity>> QueryCrawlSourceByStatusAsync(byte sourceStatus);

    /// <summary>
    /// 根据分类ID和规则解析分类列表
    /// </summary>
    Task ParseBookListAsync(int catId, RuleBeanInput ruleBean, int sourceId);

    /// <summary>
    /// 查询爬虫源
    /// </summary>
    Task<CrawlSourceEntity?> QueryCrawlSourceAsync(int sourceId);

    /// <summary>
    /// 新增单本采集任务
    /// </summary>
    Task AddCrawlSingleTaskAsync(CrawlSingleTaskInput singleTask);

    /// <summary>
    /// 单本采集任务分页列表查询
    /// </summary>
    Task<List<CrawlSingleTaskEntity>> ListCrawlSingleTaskByPageAsync(int page, int pageSize);

    /// <summary>
    /// 删除采集任务
    /// </summary>
    Task DelCrawlSingleTaskAsync(long id);

    /// <summary>
    /// 获取采集任务
    /// </summary>
    Task<CrawlSingleTaskEntity?> GetCrawlSingleTaskAsync();

    /// <summary>
    /// 更新单本采集任务
    /// </summary>
    Task UpdateCrawlSingleTaskAsync(CrawlSingleTaskInput task, byte status);

    /// <summary>
    /// 获取采集规则详细
    /// </summary>
    Task<CrawlSourceEntity?> GetCrawlSourceAsync(int id);
}
