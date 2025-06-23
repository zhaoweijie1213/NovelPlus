using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using Mapster;
using NovelPlus.Admin.Service.Domain.Entities;
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
    public async Task<ApiResult<List<AuthorCodeOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<AuthorCodeOutput>>();
        return new ApiResult<List<AuthorCodeOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单条
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<AuthorCodeOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<AuthorCodeOutput>();
        return new ApiResult<AuthorCodeOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] AuthorCodeOutput code)
    {
        var entity = code.Adapt<AuthorCodeEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] AuthorCodeOutput code)
    {
        var entity = code.Adapt<AuthorCodeEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
