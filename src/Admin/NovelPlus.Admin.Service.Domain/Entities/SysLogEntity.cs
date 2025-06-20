using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 系统日志
/// </summary>
[SugarTable("sys_log")]
public class SysLogEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 用户id
    /// </summary>
    [SugarColumn(ColumnName = "user_id")]
    public long? UserId { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    [SugarColumn(ColumnName = "username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// 用户操作
    /// </summary>
    [SugarColumn(ColumnName = "operation")]
    public string Operation { get; set; } = string.Empty;

    /// <summary>
    /// 响应时间
    /// </summary>
    [SugarColumn(ColumnName = "time")]
    public int? Time { get; set; }

    /// <summary>
    /// 请求方法
    /// </summary>
    [SugarColumn(ColumnName = "method")]
    public string Method { get; set; } = string.Empty;

    /// <summary>
    /// 请求参数
    /// </summary>
    [SugarColumn(ColumnName = "params")]
    public string Params { get; set; } = string.Empty;

    /// <summary>
    /// IP地址
    /// </summary>
    [SugarColumn(ColumnName = "ip")]
    public string Ip { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "gmt_create")]
    public DateTime? GmtCreate { get; set; }
}
