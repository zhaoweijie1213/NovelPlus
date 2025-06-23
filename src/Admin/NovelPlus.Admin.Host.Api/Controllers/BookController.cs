using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 小说接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookController(IBookService service) : ControllerBase
{
    private readonly IBookService _service = service;

    private static BookOutput ToOutput(BookEntity entity)
    {
        return new BookOutput
        {
            Id = entity.Id,
            WorkDirection = entity.WorkDirection,
            CatId = entity.CatId,
            CatName = entity.CatName,
            PicUrl = entity.PicUrl,
            BookName = entity.BookName,
            AuthorId = entity.AuthorId,
            AuthorName = entity.AuthorName,
            BookDesc = entity.BookDesc,
            Score = entity.Score,
            BookStatus = entity.BookStatus,
            VisitCount = entity.VisitCount,
            WordCount = entity.WordCount,
            CommentCount = entity.CommentCount,
            YesterdayBuy = entity.YesterdayBuy,
            LastIndexId = entity.LastIndexId,
            LastIndexName = entity.LastIndexName,
            LastIndexUpdateTime = entity.LastIndexUpdateTime,
            IsVip = entity.IsVip,
            Status = entity.Status,
            UpdateTime = entity.UpdateTime,
            CreateTime = entity.CreateTime,
            CrawlSourceId = entity.CrawlSourceId,
            CrawlBookId = entity.CrawlBookId,
            CrawlLastTime = entity.CrawlLastTime,
            CrawlIsStop = entity.CrawlIsStop
        };
    }
    /// <summary>
    /// 查询小说列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<BookOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.ConvertAll(ToOutput);
        return new ApiResult<List<BookOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单本小说
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<BookOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity == null ? null : ToOutput(entity);
        return new ApiResult<BookOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增小说
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookInput book)
    {
        var entity = new BookEntity
        {
            WorkDirection = book.WorkDirection,
            CatId = book.CatId,
            CatName = book.CatName,
            PicUrl = book.PicUrl,
            BookName = book.BookName,
            AuthorId = book.AuthorId,
            AuthorName = book.AuthorName,
            BookDesc = book.BookDesc,
            Score = book.Score,
            BookStatus = book.BookStatus,
            VisitCount = book.VisitCount,
            WordCount = book.WordCount,
            CommentCount = book.CommentCount,
            YesterdayBuy = book.YesterdayBuy,
            LastIndexId = book.LastIndexId,
            LastIndexName = book.LastIndexName,
            LastIndexUpdateTime = book.LastIndexUpdateTime,
            IsVip = book.IsVip,
            Status = book.Status,
            UpdateTime = book.UpdateTime,
            CreateTime = book.CreateTime,
            CrawlSourceId = book.CrawlSourceId,
            CrawlBookId = book.CrawlBookId,
            CrawlLastTime = book.CrawlLastTime,
            CrawlIsStop = book.CrawlIsStop
        };
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新小说
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookInput book)
    {
        var entity = new BookEntity
        {
            Id = book.Id,
            WorkDirection = book.WorkDirection,
            CatId = book.CatId,
            CatName = book.CatName,
            PicUrl = book.PicUrl,
            BookName = book.BookName,
            AuthorId = book.AuthorId,
            AuthorName = book.AuthorName,
            BookDesc = book.BookDesc,
            Score = book.Score,
            BookStatus = book.BookStatus,
            VisitCount = book.VisitCount,
            WordCount = book.WordCount,
            CommentCount = book.CommentCount,
            YesterdayBuy = book.YesterdayBuy,
            LastIndexId = book.LastIndexId,
            LastIndexName = book.LastIndexName,
            LastIndexUpdateTime = book.LastIndexUpdateTime,
            IsVip = book.IsVip,
            Status = book.Status,
            UpdateTime = book.UpdateTime,
            CreateTime = book.CreateTime,
            CrawlSourceId = book.CrawlSourceId,
            CrawlBookId = book.CrawlBookId,
            CrawlLastTime = book.CrawlLastTime,
            CrawlIsStop = book.CrawlIsStop
        };
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除小说
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
