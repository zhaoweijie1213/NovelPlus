using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 友情链接接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class FriendLinkController(IFriendLinkService service) : ControllerBase
{
    private readonly IFriendLinkService _service = service;

    /// <summary>
    /// 查询友情链接列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<FriendLinkOutput>>> ListAsync()
    {
        var result = new ApiResult<List<FriendLinkOutput>>().SetRsult(ApiResultCode.Success, new List<FriendLinkOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个友情链接
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<FriendLinkOutput?>> GetAsync(int id)
    {
        var result = new ApiResult<FriendLinkOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增友情链接
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] FriendLinkOutput link)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新友情链接
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] FriendLinkOutput link)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除友情链接
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(int id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
