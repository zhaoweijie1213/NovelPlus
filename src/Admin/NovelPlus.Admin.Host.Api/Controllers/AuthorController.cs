using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 作者接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class AuthorController(IAuthorService service) : ControllerBase
{
    private readonly IAuthorService _service = service;
    /// <summary>
    /// 查询作者列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<AuthorOutput>>> ListAsync()
    {
        var result = new ApiResult<List<AuthorOutput>>().SetRsult(ApiResultCode.Success, new List<AuthorOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个作者
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<AuthorOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<AuthorOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增作者
    /// </summary>
    [HttpPost]
    public Task<ApiResult<object>> AddAsync([FromBody] AuthorInput author)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新作者
    /// </summary>
    [HttpPut]
    public Task<ApiResult<object>> UpdateAsync([FromBody] AuthorInput author)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除作者
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<object>> DeleteAsync(long id)
    {
        var result = new ApiResult<object>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }
}
