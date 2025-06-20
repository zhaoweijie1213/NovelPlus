using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 友情链接
/// </summary>
[SugarTable("friend_link")]
public class FriendLinkEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    [SugarColumn(ColumnName = "link_name")]
    public string LinkName { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "link_url")]
    public string LinkUrl { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "sort")]
    public byte Sort { get; set; }

    [SugarColumn(ColumnName = "is_open")]
    public byte IsOpen { get; set; }

    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }

    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    [SugarColumn(ColumnName = "update_user_id")]
    public long? UpdateUserId { get; set; }

    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }
}
