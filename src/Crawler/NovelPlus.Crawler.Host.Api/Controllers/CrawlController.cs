using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using QYQ.Base.Common.ApiResult;
using NovelPlus.Crawler.Service.Application.Interfaces;
using NovelPlus.Crawler.Service.Application.Input;
using NovelPlus.Crawler.Service.Application.Output;

namespace NovelPlus.Crawler.Host.Api.Controllers;

/// <summary>
/// 爬虫接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class CrawlController(ICrawlService service) : ControllerBase
{
    private readonly ICrawlService _service = service;

    /// <summary>
    /// 新增爬虫源
    /// </summary>
    [HttpPost("AddCrawlSource")]
    public Task<ApiResult<EmptyOutput>> AddCrawlSourceAsync([FromBody] CrawlSourceInput source)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 爬虫源分页列表
    /// </summary>
    [HttpGet("ListCrawlByPage")]
    public Task<ApiResult<List<CrawlSourceOutput>>> ListCrawlByPageAsync(int page = 1, int pageSize = 10)
    {
        var result = new ApiResult<List<CrawlSourceOutput>>().SetRsult(ApiResultCode.Success, new List<CrawlSourceOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 获取爬虫源
    /// </summary>
    [HttpGet("GetCrawlSource/{id}")]
    public Task<ApiResult<CrawlSourceOutput?>> GetCrawlSourceAsync(int id)
    {
        var result = new ApiResult<CrawlSourceOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 测试规则
    /// </summary>
    [HttpPost("TestParse")]
    public Task<ApiResult<object>> TestParseAsync(string rule, string url, string? isRefresh)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, new { });
        return Task.FromResult(result);
    }

    /// <summary>
    /// 修改爬虫源
    /// </summary>
    [HttpPost("UpdateCrawlSource")]
    public Task<ApiResult<EmptyOutput>> UpdateCrawlSourceAsync([FromBody] CrawlSourceInput source)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 开启或停止爬虫
    /// </summary>
    [HttpPost("OpenOrCloseCrawl")]
    public Task<ApiResult<EmptyOutput>> OpenOrCloseCrawlAsync(int sourceId, byte sourceStatus)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增单本采集任务
    /// </summary>
    [HttpPost("AddCrawlSingleTask")]
    public Task<ApiResult<EmptyOutput>> AddCrawlSingleTaskAsync([FromBody] CrawlSingleTaskInput singleTask)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 单本采集任务分页列表查询
    /// </summary>
    [HttpGet("ListCrawlSingleTaskByPage")]
    public Task<ApiResult<List<CrawlSingleTaskOutput>>> ListCrawlSingleTaskByPageAsync(int page = 1, int pageSize = 10)
    {
        var result = new ApiResult<List<CrawlSingleTaskOutput>>().SetRsult(ApiResultCode.Success, new List<CrawlSingleTaskOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除采集任务
    /// </summary>
    [HttpDelete("DelCrawlSingleTask/{id}")]
    public Task<ApiResult<EmptyOutput>> DelCrawlSingleTaskAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
