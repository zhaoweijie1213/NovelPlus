using System;

namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 新闻类别输入
/// </summary>
public class CategoryInput
{
    /// <summary>
    /// 主键，用于更新
    /// </summary>
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public byte Sort { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? UpdateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
}
