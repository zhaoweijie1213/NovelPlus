using System;
using SqlSugar;

namespace NovelPlus.Portal.Service.Domain.Entities;

/// <summary>
/// 用户反馈
/// </summary>
[SugarTable("user_feedback")]
public class UserFeedbackEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    [SugarColumn(ColumnName = "user_id")]
    public long? UserId { get; set; }

    /// <summary>
    /// 反馈内容
    /// </summary>
    [SugarColumn(ColumnName = "content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }
}
