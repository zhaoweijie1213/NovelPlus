using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 用户反馈接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class UserFeedbackController(IUserFeedbackService service) : ControllerBase
{
    private readonly IUserFeedbackService _service = service;

    /// <summary>
    /// 查询反馈列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<UserFeedbackOutput>>> ListAsync()
    {
        var result = new ApiResult<List<UserFeedbackOutput>>().SetRsult(ApiResultCode.Success, new List<UserFeedbackOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个反馈
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<UserFeedbackOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<UserFeedbackOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增反馈
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] UserFeedbackOutput feedback)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新反馈
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] UserFeedbackOutput feedback)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除反馈
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
