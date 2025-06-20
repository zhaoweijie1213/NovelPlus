namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 小说目录输出
/// </summary>
public class BookIndexOutput
{
    public long Id { get; set; }
    public long BookId { get; set; }
    public int IndexNum { get; set; }
    public string IndexName { get; set; } = string.Empty;
    public int? WordCount { get; set; }
    public byte? IsVip { get; set; }
    public int? BookPrice { get; set; }
    public string StorageType { get; set; } = string.Empty;
    public DateTime? CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
}
