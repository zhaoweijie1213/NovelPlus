using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 新闻类别表
    ///</summary>
    [SugarTable("news_category")]
    public class NewsCategoryEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
         
        /// <summary>
        /// 分类名 
        ///</summary>
         [SugarColumn(ColumnName="name"    )]
         public string Name { get; set; }
         
        /// <summary>
        /// 排序 
        /// 默认值: 10
        ///</summary>
         [SugarColumn(ColumnName="sort"    )]
         public byte Sort { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="create_user_id"    )]
         public long? CreateUserId { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="update_user_id"    )]
         public long? UpdateUserId { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="update_time"    )]
         public DateTime? UpdateTime { get; set; }
         
    }
}
