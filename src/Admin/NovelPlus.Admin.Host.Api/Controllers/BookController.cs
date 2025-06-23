using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
using Mapster;
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

    /// <summary>
    /// 查询小说列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<BookOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<BookOutput>>();
        return new ApiResult<List<BookOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单本小说
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<BookOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<BookOutput>();
        return new ApiResult<BookOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增小说
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookInput book)
    {
        var entity = book.Adapt<BookEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新小说
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookInput book)
    {
        var entity = book.Adapt<BookEntity>();
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
