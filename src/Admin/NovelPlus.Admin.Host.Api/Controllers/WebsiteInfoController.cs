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
    public async Task<ApiResult<List<WebsiteInfoOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<WebsiteInfoOutput>>();
        return new ApiResult<List<WebsiteInfoOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个网站信息
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<WebsiteInfoOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<WebsiteInfoOutput>();
        return new ApiResult<WebsiteInfoOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增网站信息
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] WebsiteInfoOutput info)
    {
        var entity = info.Adapt<WebsiteInfoEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新网站信息
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] WebsiteInfoOutput info)
    {
        var entity = info.Adapt<WebsiteInfoEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除网站信息
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
