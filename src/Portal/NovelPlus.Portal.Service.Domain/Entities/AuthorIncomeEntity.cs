using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace NovelPlus.Portal.Service.Domain.Entities
{
    /// <summary>
    /// 稿费收入统计表
    ///</summary>
    [SugarTable("author_income")]
    public class AuthorIncomeEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
        [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
        public long Id { get; set; }

        /// <summary>
        /// 用户ID 
        ///</summary>
        [SugarColumn(ColumnName = "user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 作家ID 
        ///</summary>
        [SugarColumn(ColumnName = "author_id")]
        public long AuthorId { get; set; }

        /// <summary>
        /// 作品ID 
        ///</summary>
        [SugarColumn(ColumnName = "book_id")]
        public long BookId { get; set; }

        /// <summary>
        /// 收入月份 
        ///</summary>
        [SugarColumn(ColumnName = "income_month")]
        public DateTime IncomeMonth { get; set; }

        /// <summary>
        /// 税前收入（分） 
        /// 默认值: 0
        ///</summary>
        [SugarColumn(ColumnName = "pre_tax_income")]
        public long PreTaxIncome { get; set; }

        /// <summary>
        /// 税后收入（分） 
        /// 默认值: 0
        ///</summary>
        [SugarColumn(ColumnName = "after_tax_income")]
        public long AfterTaxIncome { get; set; }

        /// <summary>
        /// 支付状态，0：待支付，1：已支付 
        /// 默认值: 0
        ///</summary>
        [SugarColumn(ColumnName = "pay_status")]
        public byte PayStatus { get; set; }

        /// <summary>
        /// 稿费确认状态，0：待确认，1：已确认 
        /// 默认值: 0
        ///</summary>
        [SugarColumn(ColumnName = "confirm_status")]
        public byte ConfirmStatus { get; set; }

        /// <summary>
        /// 详情 
        ///</summary>
        [SugarColumn(ColumnName = "detail")]
        public string Detail { get; set; } = string.Empty;

        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "create_time")]
        public DateTime? CreateTime { get; set; }

    }
}
