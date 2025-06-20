using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 小说类别表
    ///</summary>
    [SugarTable("book_category")]
    public class BookCategoryEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
         
        /// <summary>
        /// 作品方向，0：男频，1：女频&#39; 
        ///</summary>
         [SugarColumn(ColumnName="work_direction"    )]
         public byte? WorkDirection { get; set; }
         
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
