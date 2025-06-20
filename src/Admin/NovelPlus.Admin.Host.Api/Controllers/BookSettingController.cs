using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 首页小说设置接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookSettingController(IBookSettingService service) : ControllerBase
{
    private readonly IBookSettingService _service = service;

    /// <summary>
    /// 查询设置列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<BookSettingOutput>>> ListAsync()
    {
        var result = new ApiResult<List<BookSettingOutput>>().SetRsult(ApiResultCode.Success, new List<BookSettingOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个设置
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<BookSettingOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<BookSettingOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增设置
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookSettingOutput setting)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新设置
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookSettingOutput setting)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除设置
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
