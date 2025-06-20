using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 充值订单接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class PayController(IPayService service) : ControllerBase
{
    private readonly IPayService _service = service;

    [HttpGet("List")]
    public Task<ApiResult<List<OrderPayOutput>>> ListAsync()
    {
        var result = new ApiResult<List<OrderPayOutput>>().SetRsult(ApiResultCode.Success, new List<OrderPayOutput>());
        return Task.FromResult(result);
    }

    [HttpGet("{id}")]
    public Task<ApiResult<OrderPayOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<OrderPayOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] OrderPayOutput order)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] OrderPayOutput order)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
