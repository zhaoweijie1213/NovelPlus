using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 作家接口
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
    /// 校验笔名
    /// </summary>
    [HttpGet("CheckPenName")]
    public Task<ApiResult<bool>> CheckPenNameAsync(string penName)
    {
        var result = new ApiResult<bool>().SetRsult(ApiResultCode.Success, false);
        return Task.FromResult(result);
    }
}
