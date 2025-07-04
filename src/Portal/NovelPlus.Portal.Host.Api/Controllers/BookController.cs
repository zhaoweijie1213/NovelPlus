using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 小说接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookController(IBookService service) : ControllerBase
{
    private readonly IBookService _service = service;

    /// <summary>
    /// 查询首页小说设置
    /// </summary>
    [HttpGet("ListSetting")]
    public Task<ApiResult<Dictionary<byte, List<BookSettingOutput>>>> ListSettingAsync()
    {
        var result = new ApiResult<Dictionary<byte, List<BookSettingOutput>>>()
            .SetRsult(ApiResultCode.Success, new Dictionary<byte, List<BookSettingOutput>>());
        return Task.FromResult(result);
    }
}
