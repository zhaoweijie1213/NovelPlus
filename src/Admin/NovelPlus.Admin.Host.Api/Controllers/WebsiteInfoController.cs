using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 网站信息接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class WebsiteInfoController(IWebsiteInfoService service) : ControllerBase
{
    private readonly IWebsiteInfoService _service = service;

    /// <summary>
    /// 查询网站信息列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<WebsiteInfoOutput>>> ListAsync()
    {
        var result = new ApiResult<List<WebsiteInfoOutput>>().SetRsult(ApiResultCode.Success, new List<WebsiteInfoOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个网站信息
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<WebsiteInfoOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<WebsiteInfoOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增网站信息
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] WebsiteInfoOutput info)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新网站信息
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] WebsiteInfoOutput info)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除网站信息
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
