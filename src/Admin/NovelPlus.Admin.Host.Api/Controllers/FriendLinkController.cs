using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;
using Mapster;
using NovelPlus.Admin.Service.Domain.Entities;

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
    public async Task<ApiResult<List<FriendLinkOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<FriendLinkOutput>>();
        return new ApiResult<List<FriendLinkOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个友情链接
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<FriendLinkOutput?>> GetAsync(int id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<FriendLinkOutput>();
        return new ApiResult<FriendLinkOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增友情链接
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] FriendLinkOutput link)
    {
        var entity = link.Adapt<FriendLinkEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新友情链接
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] FriendLinkOutput link)
    {
        var entity = link.Adapt<FriendLinkEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除友情链接
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(int id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
