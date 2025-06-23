using System;

namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 新闻类别输出
/// </summary>
public class CategoryOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 类别名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 排序值
    /// </summary>
    public byte Sort { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新人ID
    /// </summary>
    public long? UpdateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
