using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 爬虫源表
    ///</summary>
    [SugarTable("crawl_source")]
    public class CrawlSourceEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
         
        /// <summary>
        /// 源站名 
        ///</summary>
         [SugarColumn(ColumnName="source_name"    )]
         public string SourceName { get; set; }
         
        /// <summary>
        /// 爬取规则（json串） 
        ///</summary>
         [SugarColumn(ColumnName="crawl_rule"    )]
         public string CrawlRule { get; set; }
         
        /// <summary>
        /// 爬虫源状态，0：关闭，1：开启 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="source_status"    )]
         public byte? SourceStatus { get; set; }
         
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
