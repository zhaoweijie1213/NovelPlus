using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 作家邀请码接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class AuthorCodeController(IAuthorCodeService service) : ControllerBase
{
    private readonly IAuthorCodeService _service = service;

    /// <summary>
    /// 查询列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<AuthorCodeOutput>>> ListAsync()
    {
        var result = new ApiResult<List<AuthorCodeOutput>>().SetRsult(ApiResultCode.Success, new List<AuthorCodeOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单条
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<AuthorCodeOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<AuthorCodeOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] AuthorCodeOutput code)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] AuthorCodeOutput code)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
