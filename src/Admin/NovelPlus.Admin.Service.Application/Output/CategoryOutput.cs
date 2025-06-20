using System;

namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 新闻类别输出
/// </summary>
public class CategoryOutput
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public byte Sort { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? UpdateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
}
