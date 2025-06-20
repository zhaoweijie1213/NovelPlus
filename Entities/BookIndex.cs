using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 小说目录表
    ///</summary>
    [SugarTable("book_index")]
    public class BookIndexEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 小说ID 
        ///</summary>
         [SugarColumn(ColumnName="book_id"    )]
         public long BookId { get; set; }
         
        /// <summary>
        /// 目录号 
        ///</summary>
         [SugarColumn(ColumnName="index_num"    )]
         public int IndexNum { get; set; }
         
        /// <summary>
        /// 目录名 
        ///</summary>
         [SugarColumn(ColumnName="index_name"    )]
         public string IndexName { get; set; }
         
        /// <summary>
        /// 字数 
        ///</summary>
         [SugarColumn(ColumnName="word_count"    )]
         public int? WordCount { get; set; }
         
        /// <summary>
        /// 是否收费，1：收费，0：免费 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="is_vip"    )]
         public byte? IsVip { get; set; }
         
        /// <summary>
        /// 章节费用（屋币） 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="book_price"    )]
         public int? BookPrice { get; set; }
         
        /// <summary>
        /// 存储方式 
        /// 默认值: db
        ///</summary>
         [SugarColumn(ColumnName="storage_type"    )]
         public string StorageType { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="update_time"    )]
         public DateTime? UpdateTime { get; set; }
         
    }
}
