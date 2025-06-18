namespace PayService.Service.Domain.Entities;

/// <summary>
/// 订单实体
/// </summary>
public class Order
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 金额
    /// </summary>
    public decimal Amount { get; set; }
}
