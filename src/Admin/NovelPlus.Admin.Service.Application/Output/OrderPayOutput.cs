namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 充值订单输出
/// </summary>
public class OrderPayOutput
{
    public long Id { get; set; }
    public long OutTradeNo { get; set; }
    public string TradeNo { get; set; } = string.Empty;
    public byte PayChannel { get; set; }
    public int TotalAmount { get; set; }
    public long UserId { get; set; }
    public byte? PayStatus { get; set; }
    public DateTime? CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
}
