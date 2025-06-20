using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 抓取单本小说任务表
    ///</summary>
    [SugarTable("crawl_single_task")]
    public class CrawlSingleTaskEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 爬虫源ID 
        ///</summary>
         [SugarColumn(ColumnName="source_id"    )]
         public int? SourceId { get; set; }
         
        /// <summary>
        /// 爬虫源名 
        ///</summary>
         [SugarColumn(ColumnName="source_name"    )]
         public string SourceName { get; set; }
         
        /// <summary>
        /// 源站小说ID 
        ///</summary>
         [SugarColumn(ColumnName="source_book_id"    )]
         public string SourceBookId { get; set; }
         
        /// <summary>
        /// 分类ID 
        ///</summary>
         [SugarColumn(ColumnName="cat_id"    )]
         public int? CatId { get; set; }
         
        /// <summary>
        /// 爬取的小说名 
        ///</summary>
         [SugarColumn(ColumnName="book_name"    )]
         public string BookName { get; set; }
         
        /// <summary>
        /// 爬取的小说作者名 
        ///</summary>
         [SugarColumn(ColumnName="author_name"    )]
         public string AuthorName { get; set; }
         
        /// <summary>
        /// 任务状态，0：失败，1：成功，2；未执行 
        /// 默认值: 2
        ///</summary>
         [SugarColumn(ColumnName="task_status"    )]
         public byte? TaskStatus { get; set; }
         
        /// <summary>
        /// 已经执行次数，最多执行5次 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="exc_count"    )]
         public byte? ExcCount { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
    }
}
