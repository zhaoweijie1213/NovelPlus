using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
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
    public Task<ApiResult<List<BookOutput>>> ListAsync()
    {
        var result = new ApiResult<List<BookOutput>>().SetRsult(ApiResultCode.Success, new List<BookOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单本小说
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<BookOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<BookOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增小说
    /// </summary>
    [HttpPost]
    public Task<ApiResult<object>> AddAsync([FromBody] BookInput book)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新小说
    /// </summary>
    [HttpPut]
    public Task<ApiResult<object>> UpdateAsync([FromBody] BookInput book)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除小说
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<object>> DeleteAsync(long id)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }
}
