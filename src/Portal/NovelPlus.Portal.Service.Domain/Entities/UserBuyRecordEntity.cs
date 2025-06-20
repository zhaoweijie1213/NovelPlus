using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace NovelPlus.Portal.Service.Domain.Entities
{
    /// <summary>
    /// 用户消费记录表
    ///</summary>
    [SugarTable("user_buy_record")]
    public class UserBuyRecordEntity
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
        /// 购买的小说ID 
        ///</summary>
        [SugarColumn(ColumnName = "book_id")]
        public long? BookId { get; set; }

        /// <summary>
        /// 购买的小说名 
        ///</summary>
        [SugarColumn(ColumnName = "book_name")]
        public string BookName { get; set; } = string.Empty;

        /// <summary>
        /// 购买的章节ID 
        ///</summary>
        [SugarColumn(ColumnName = "book_index_id")]
        public long? BookIndexId { get; set; }

        /// <summary>
        /// 购买的章节名 
        ///</summary>
        [SugarColumn(ColumnName = "book_index_name")]
        public string BookIndexName { get; set; } = string.Empty;

        /// <summary>
        /// 购买使用的屋币数量 
        ///</summary>
        [SugarColumn(ColumnName = "buy_amount")]
        public int? BuyAmount { get; set; }

        /// <summary>
        /// 购买时间 
        ///</summary>
        [SugarColumn(ColumnName = "create_time")]
        public DateTime? CreateTime { get; set; }

    }
}
