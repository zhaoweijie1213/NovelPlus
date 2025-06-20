namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 首页小说设置输出
/// </summary>
public class BookSettingOutput
{
    public long Id { get; set; }
    public long? BookId { get; set; }
    public byte? Sort { get; set; }
    public byte? Type { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
    public long? UpdateUserId { get; set; }
}
