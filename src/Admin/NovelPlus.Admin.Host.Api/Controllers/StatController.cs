using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;
using System.Linq;
using System;
using Mapster;

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
    public async Task<ApiResult<StatCountOutput>> CountStaAsync()
    {
        var output = new StatCountOutput
        {
            UserCount = await _userService.CountAsync(new Dictionary<string, object>()),
            AuthorCount = await _authorService.CountAsync(new Dictionary<string, object>()),
            BookCount = await _bookService.CountAsync(new Dictionary<string, object>()),
            OrderCount = await _payService.CountAsync(new Dictionary<string, object>())
        };
        return new ApiResult<StatCountOutput>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 获取表统计
    /// </summary>
    [HttpGet("TableSta")]
    public async Task<ApiResult<StatTableOutput>> TableStaAsync()
    {
        var minDate = DateTime.Now.AddDays(-30);
        var userSta = await _userService.TableStaAsync(minDate);
        var authorSta = await _authorService.TableStaAsync(minDate);
        var bookSta = await _bookService.TableStaAsync(minDate);
        var orderSta = await _payService.TableStaAsync(minDate);

        var dates = userSta.Keys.Select(k => k?.ToString() ?? string.Empty).ToList();

        var output = new StatTableOutput
        {
            DateList = dates,
            UserTableSta = userSta.ToDictionary(k => k.Key?.ToString() ?? string.Empty, v => Convert.ToInt32(v.Value)),
            BookTableSta = bookSta.ToDictionary(k => k.Key?.ToString() ?? string.Empty, v => Convert.ToInt32(v.Value)),
            AuthorTableSta = authorSta.ToDictionary(k => k.Key?.ToString() ?? string.Empty, v => Convert.ToInt32(v.Value)),
            OrderTableSta = orderSta.ToDictionary(k => k.Key?.ToString() ?? string.Empty, v => Convert.ToInt32(v.Value))
        };

        return new ApiResult<StatTableOutput>().SetRsult(ApiResultCode.Success, output);
    }
}
