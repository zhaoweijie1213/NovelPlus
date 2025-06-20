namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 网站信息输出
/// </summary>
public class WebsiteInfoOutput
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public string Keyword { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Qq { get; set; } = string.Empty;
    public string Logo { get; set; } = string.Empty;
    public string LogoDark { get; set; } = string.Empty;
    public DateTime? CreateTime { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
    public long? UpdateUserId { get; set; }
}
