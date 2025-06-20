using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("user_feedback")]
    public class UserFeedbackEntity
    {
        /// <summary>
        /// 主键id 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 用户id 
        ///</summary>
         [SugarColumn(ColumnName="user_id"    )]
         public long? UserId { get; set; }
         
        /// <summary>
        /// 反馈内容 
        ///</summary>
         [SugarColumn(ColumnName="content"    )]
         public string Content { get; set; }
         
        /// <summary>
        /// 反馈时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
    }
}
