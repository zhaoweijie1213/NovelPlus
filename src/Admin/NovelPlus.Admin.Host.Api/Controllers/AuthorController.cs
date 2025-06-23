using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Domain.Entities;
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

    private static AuthorOutput ToOutput(AuthorEntity entity)
    {
        return new AuthorOutput
        {
            Id = entity.Id,
            UserId = entity.UserId,
            InviteCode = entity.InviteCode,
            PenName = entity.PenName,
            TelPhone = entity.TelPhone,
            ChatAccount = entity.ChatAccount,
            Email = entity.Email,
            WorkDirection = entity.WorkDirection,
            Status = entity.Status,
            CreateTime = entity.CreateTime
        };
    }
    /// <summary>
    /// 查询作者列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<AuthorOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.ConvertAll(ToOutput);
        return new ApiResult<List<AuthorOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个作者
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<AuthorOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity == null ? null : ToOutput(entity);
        return new ApiResult<AuthorOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增作者
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] AuthorInput author)
    {
        var entity = new AuthorEntity
        {
            UserId = author.UserId,
            InviteCode = author.InviteCode,
            PenName = author.PenName,
            TelPhone = author.TelPhone,
            ChatAccount = author.ChatAccount,
            Email = author.Email,
            WorkDirection = author.WorkDirection,
            Status = author.Status
        };
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新作者
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] AuthorInput author)
    {
        var entity = new AuthorEntity
        {
            Id = author.Id,
            UserId = author.UserId,
            InviteCode = author.InviteCode,
            PenName = author.PenName,
            TelPhone = author.TelPhone,
            ChatAccount = author.ChatAccount,
            Email = author.Email,
            WorkDirection = author.WorkDirection,
            Status = author.Status
        };
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除作者
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
