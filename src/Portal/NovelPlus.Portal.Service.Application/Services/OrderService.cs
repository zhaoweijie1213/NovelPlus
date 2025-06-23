using Microsoft.Extensions.Logging;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 订单服务实现
/// </summary>
public class OrderService(IOrderRepository repository, ILogger<OrderService> logger) : IOrderService
{
    private readonly IOrderRepository _repository = repository;
    private readonly ILogger<OrderService> _logger = logger;

    /// <summary>
    /// 创建支付订单
    /// </summary>
    /// <param name="payChannel">支付渠道</param>
    /// <param name="payAmount">支付金额</param>
    /// <param name="userId">用户ID</param>
    /// <returns>订单号</returns>
    public async Task<long> CreatePayOrderAsync(byte payChannel, int payAmount, long userId)
    {
        var now = DateTime.Now;
        var outTradeNo = long.Parse($"{now:yyyyMMddHHmmssfff}{Random.Shared.Next(0, 10)}");
        var order = new OrderPayEntity
        {
            OutTradeNo = outTradeNo,
            PayChannel = payChannel,
            TotalAmount = payAmount,
            UserId = userId,
            PayStatus = 2,
            CreateTime = now,
            UpdateTime = now
        };
        await _repository.SaveAsync(order);
        _logger.LogInformation("Create order {No}", outTradeNo);
        return outTradeNo;
    }
}
