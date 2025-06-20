using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 批量抓取任务表
    ///</summary>
    [SugarTable("crawl_batch_task")]
    public class CrawlBatchTaskEntity
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
        /// 成功抓取数量 
        ///</summary>
         [SugarColumn(ColumnName="crawl_count_success"    )]
         public int? CrawlCountSuccess { get; set; }
         
        /// <summary>
        /// 目标抓取数量 
        ///</summary>
         [SugarColumn(ColumnName="crawl_count_target"    )]
         public int? CrawlCountTarget { get; set; }
         
        /// <summary>
        /// 任务状态，1：正在运行，0已停止 
        /// 默认值: 1
        ///</summary>
         [SugarColumn(ColumnName="task_status"    )]
         public byte? TaskStatus { get; set; }
         
        /// <summary>
        /// 任务开始时间 
        ///</summary>
         [SugarColumn(ColumnName="start_time"    )]
         public DateTime? StartTime { get; set; }
         
        /// <summary>
        /// 任务结束时间 
        ///</summary>
         [SugarColumn(ColumnName="end_time"    )]
         public DateTime? EndTime { get; set; }
         
    }
}
