using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 充值订单
/// </summary>
[SugarTable("order_pay")]
public class OrderPayEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "out_trade_no")]
    public long OutTradeNo { get; set; }

    [SugarColumn(ColumnName = "trade_no")]
    public string TradeNo { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "pay_channel")]
    public byte PayChannel { get; set; }

    [SugarColumn(ColumnName = "total_amount")]
    public int TotalAmount { get; set; }

    [SugarColumn(ColumnName = "user_id")]
    public long UserId { get; set; }

    [SugarColumn(ColumnName = "pay_status")]
    public byte? PayStatus { get; set; }

    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }
}
