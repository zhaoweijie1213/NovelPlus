using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 新闻表
    ///</summary>
    [SugarTable("news")]
    public class NewsEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 类别ID 
        ///</summary>
         [SugarColumn(ColumnName="cat_id"    )]
         public int? CatId { get; set; }
         
        /// <summary>
        /// 分类名 
        ///</summary>
         [SugarColumn(ColumnName="cat_name"    )]
         public string CatName { get; set; }
         
        /// <summary>
        /// 来源 
        ///</summary>
         [SugarColumn(ColumnName="source_name"    )]
         public string SourceName { get; set; }
         
        /// <summary>
        /// 标题 
        ///</summary>
         [SugarColumn(ColumnName="title"    )]
         public string Title { get; set; }
         
        /// <summary>
        /// 内容 
        ///</summary>
         [SugarColumn(ColumnName="content"    )]
         public string Content { get; set; }
         
        /// <summary>
        /// 阅读量 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="read_count"    )]
         public long ReadCount { get; set; }
         
        /// <summary>
        /// 发布时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        /// 发布人ID 
        ///</summary>
         [SugarColumn(ColumnName="create_user_id"    )]
         public long? CreateUserId { get; set; }
         
        /// <summary>
        /// 更新时间 
        ///</summary>
         [SugarColumn(ColumnName="update_time"    )]
         public DateTime? UpdateTime { get; set; }
         
        /// <summary>
        /// 更新人ID 
        ///</summary>
         [SugarColumn(ColumnName="update_user_id"    )]
         public long? UpdateUserId { get; set; }
         
    }
}
