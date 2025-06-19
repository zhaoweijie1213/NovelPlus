namespace PayService.Service.Domain.Entities;

using System;

/// <summary>
/// 订单实体
/// </summary>
public class Order
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 商户订单号
    /// </summary>
    public long OutTradeNo { get; set; }

    /// <summary>
    /// 支付平台交易号
    /// </summary>
    public string TradeNo { get; set; } = string.Empty;

    /// <summary>
    /// 支付渠道
    /// </summary>
    public byte PayChannel { get; set; }

    /// <summary>
    /// 订单金额
    /// </summary>
    public int TotalAmount { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// 支付状态
    /// </summary>
    public byte PayStatus { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
