using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 充值订单
    ///</summary>
    [SugarTable("order_pay")]
    public class OrderPayEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 商户订单号 
        ///</summary>
         [SugarColumn(ColumnName="out_trade_no"    )]
         public long OutTradeNo { get; set; }
         
        /// <summary>
        /// 支付宝/微信交易号 
        ///</summary>
         [SugarColumn(ColumnName="trade_no"    )]
         public string TradeNo { get; set; }
         
        /// <summary>
        /// 支付渠道，1：支付宝，2：微信 
        /// 默认值: 1
        ///</summary>
         [SugarColumn(ColumnName="pay_channel"    )]
         public byte PayChannel { get; set; }
         
        /// <summary>
        /// 交易金额(单位元) 
        ///</summary>
         [SugarColumn(ColumnName="total_amount"    )]
         public int TotalAmount { get; set; }
         
        /// <summary>
        /// 支付用户ID 
        ///</summary>
         [SugarColumn(ColumnName="user_id"    )]
         public long UserId { get; set; }
         
        /// <summary>
        /// 支付状态：0：支付失败，1：支付成功，2：待支付 
        /// 默认值: 2
        ///</summary>
         [SugarColumn(ColumnName="pay_status"    )]
         public byte? PayStatus { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        /// 更新时间 
        ///</summary>
         [SugarColumn(ColumnName="update_time"    )]
         public DateTime? UpdateTime { get; set; }
         
    }
}
