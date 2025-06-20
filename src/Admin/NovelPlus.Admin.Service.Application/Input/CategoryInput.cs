using System;

namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 新闻类别输入
/// </summary>
public class CategoryInput
{
    public string Name { get; set; } = string.Empty;
    public byte Sort { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? UpdateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
}
