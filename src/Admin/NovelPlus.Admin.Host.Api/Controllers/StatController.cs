using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 统计接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class StatController(IUserService userService, IAuthorService authorService, IBookService bookService, IPayService payService) : ControllerBase
{
    private readonly IUserService _userService = userService;
    private readonly IAuthorService _authorService = authorService;
    private readonly IBookService _bookService = bookService;
    private readonly IPayService _payService = payService;

    /// <summary>
    /// 获取数量统计
    /// </summary>
    [HttpGet("CountSta")]
    public Task<ApiResult<StatCountOutput>> CountStaAsync()
    {
        var output = new StatCountOutput();
        var result = new ApiResult<StatCountOutput>().SetRsult(ApiResultCode.Success, output);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 获取表统计
    /// </summary>
    [HttpGet("TableSta")]
    public Task<ApiResult<StatTableOutput>> TableStaAsync()
    {
        var output = new StatTableOutput();
        var result = new ApiResult<StatTableOutput>().SetRsult(ApiResultCode.Success, output);
        return Task.FromResult(result);
    }
}
