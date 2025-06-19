namespace ContentService.Service.Domain.Entities;

using System;

/// <summary>
/// 新闻实体
/// </summary>
public class News
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 类别ID
    /// </summary>
    public int CatId { get; set; }

    /// <summary>
    /// 分类名
    /// </summary>
    public string CatName { get; set; } = string.Empty;

    /// <summary>
    /// 来源
    /// </summary>
    public string SourceName { get; set; } = string.Empty;

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 发布时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 发布人ID
    /// </summary>
    public long CreateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 更新人ID
    /// </summary>
    public long UpdateUserId { get; set; }
}
