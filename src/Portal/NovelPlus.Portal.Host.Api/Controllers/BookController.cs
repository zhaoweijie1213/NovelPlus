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
    public async Task<ApiResult<Dictionary<int, List<BookSettingOutput>>>> ListSettingAsync()
    {
        var data = await _service.ListBookSettingAsync();
        return new ApiResult<Dictionary<int, List<BookSettingOutput>>>().SetRsult(ApiResultCode.Success, data);
    }
}
