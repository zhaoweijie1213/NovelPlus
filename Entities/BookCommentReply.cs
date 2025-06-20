using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 小说评论回复表
    ///</summary>
    [SugarTable("book_comment_reply")]
    public class BookCommentReplyEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true   )]
         public long Id { get; set; }
         
        /// <summary>
        /// 评论ID 
        ///</summary>
         [SugarColumn(ColumnName="comment_id"    )]
         public long? CommentId { get; set; }
         
        /// <summary>
        /// 回复内容 
        ///</summary>
         [SugarColumn(ColumnName="reply_content"    )]
         public string ReplyContent { get; set; }
         
        /// <summary>
        /// 审核状态，0：待审核，1：审核通过，2：审核不通过 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="audit_status"    )]
         public byte? AuditStatus { get; set; }
         
        /// <summary>
        /// 回复用户ID 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        /// 回复时间 
        ///</summary>
         [SugarColumn(ColumnName="create_user_id"    )]
         public long? CreateUserId { get; set; }
         
    }
}
