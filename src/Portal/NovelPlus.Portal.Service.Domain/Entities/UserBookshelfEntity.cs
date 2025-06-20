using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace NovelPlus.Portal.Service.Domain.Entities
{
    /// <summary>
    /// 用户书架表
    ///</summary>
    [SugarTable("user_bookshelf")]
    public class UserBookshelfEntity
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
        /// 小说ID 
        ///</summary>
        [SugarColumn(ColumnName = "book_id")]
        public long BookId { get; set; }

        /// <summary>
        /// 上一次阅读的章节内容表ID 
        ///</summary>
        [SugarColumn(ColumnName = "pre_content_id")]
        public long? PreContentId { get; set; }

        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "create_time")]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "update_time")]
        public DateTime? UpdateTime { get; set; }

    }
}
