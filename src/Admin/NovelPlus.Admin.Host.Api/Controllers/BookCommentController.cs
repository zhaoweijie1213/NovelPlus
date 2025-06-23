using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 小说评论接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookCommentController(IBookCommentService service) : ControllerBase
{
    private readonly IBookCommentService _service = service;

    private static BookCommentOutput ToOutput(BookCommentEntity entity)
    {
        return new BookCommentOutput
        {
            Id = entity.Id,
            BookId = entity.BookId,
            CommentContent = entity.CommentContent,
            ReplyCount = entity.ReplyCount,
            AuditStatus = entity.AuditStatus,
            CreateTime = entity.CreateTime,
            CreateUserId = entity.CreateUserId
        };
    }

    /// <summary>
    /// 查询评论列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<BookCommentOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.ConvertAll(ToOutput);
        return new ApiResult<List<BookCommentOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个评论
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<BookCommentOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity == null ? null : ToOutput(entity);
        return new ApiResult<BookCommentOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增评论
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookCommentOutput comment)
    {
        var entity = new BookCommentEntity
        {
            BookId = comment.BookId,
            CommentContent = comment.CommentContent,
            ReplyCount = comment.ReplyCount,
            AuditStatus = comment.AuditStatus,
            CreateTime = comment.CreateTime,
            CreateUserId = comment.CreateUserId
        };
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新评论
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookCommentOutput comment)
    {
        var entity = new BookCommentEntity
        {
            Id = comment.Id,
            BookId = comment.BookId,
            CommentContent = comment.CommentContent,
            ReplyCount = comment.ReplyCount,
            AuditStatus = comment.AuditStatus,
            CreateTime = comment.CreateTime,
            CreateUserId = comment.CreateUserId
        };
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除评论
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
