using System;
using SqlSugar;

namespace NovelPlus.Portal.Service.Domain.Entities;

/// <summary>
/// 小说评论表
/// </summary>
[SugarTable("book_comment")]
public class BookCommentEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 小说ID
    /// </summary>
    [SugarColumn(ColumnName = "book_id")]
    public long? BookId { get; set; }

    /// <summary>
    /// 评价内容
    /// </summary>
    [SugarColumn(ColumnName = "comment_content")]
    public string CommentContent { get; set; } = string.Empty;

    /// <summary>
    /// 回复数量
    /// </summary>
    [SugarColumn(ColumnName = "reply_count")]
    public int? ReplyCount { get; set; }

    /// <summary>
    /// 审核状态，0：待审核，1：审核通过，2：审核不通过
    /// </summary>
    [SugarColumn(ColumnName = "audit_status")]
    public byte? AuditStatus { get; set; }

    /// <summary>
    /// 评价时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 评价人
    /// </summary>
    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }
}
