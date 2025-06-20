using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 支付接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class PayController(IOrderService service) : ControllerBase
{
    private readonly IOrderService _service = service;

    /// <summary>
    /// 创建充值订单
    /// </summary>
    [HttpPost("CreateOrder")]
    public Task<ApiResult<long>> CreateOrderAsync()
    {
        var result = new ApiResult<long>().SetRsult(ApiResultCode.Success, 0);
        return Task.FromResult(result);
    }
}
