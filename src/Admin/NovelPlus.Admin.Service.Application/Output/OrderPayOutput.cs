namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 充值订单输出
/// </summary>
public class OrderPayOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 外部订单号
    /// </summary>
    public long OutTradeNo { get; set; }

    /// <summary>
    /// 第三方交易号
    /// </summary>
    public string TradeNo { get; set; } = string.Empty;

    /// <summary>
    /// 支付渠道
    /// </summary>
    public byte PayChannel { get; set; }

    /// <summary>
    /// 支付金额
    /// </summary>
    public int TotalAmount { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// 支付状态
    /// </summary>
    public byte? PayStatus { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
