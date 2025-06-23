using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;
using Mapster;
using NovelPlus.Admin.Service.Domain.Entities;

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

    /// <summary>
    /// 查询充值订单列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<OrderPayOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<OrderPayOutput>>();
        return new ApiResult<List<OrderPayOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询充值订单
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<OrderPayOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<OrderPayOutput>();
        return new ApiResult<OrderPayOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增订单
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] OrderPayOutput order)
    {
        var entity = order.Adapt<OrderPayEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新订单
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] OrderPayOutput order)
    {
        var entity = order.Adapt<OrderPayEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除订单
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
