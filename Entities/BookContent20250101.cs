using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 小说内容表
    ///</summary>
    [SugarTable("book_content_20250101")]
    public class BookContent20250101Entity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 目录ID 
        ///</summary>
         [SugarColumn(ColumnName="index_id"    )]
         public long? IndexId { get; set; }
         
        /// <summary>
        /// 小说章节内容 
        ///</summary>
         [SugarColumn(ColumnName="content"    )]
         public string Content { get; set; }
         
    }
}
