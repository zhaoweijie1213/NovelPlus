using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 用户反馈
/// </summary>
[SugarTable("user_feedback")]
public class UserFeedbackEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "user_id")]
    public long? UserId { get; set; }

    [SugarColumn(ColumnName = "content")]
    public string Content { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }
}
