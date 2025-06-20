namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 友情链接输出
/// </summary>
public class FriendLinkOutput
{
    public int Id { get; set; }
    public string LinkName { get; set; } = string.Empty;
    public string LinkUrl { get; set; } = string.Empty;
    public byte Sort { get; set; }
    public byte IsOpen { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? UpdateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
}
