namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 网站信息输出
/// </summary>
public class WebsiteInfoOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 网站名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 域名
    /// </summary>
    public string Domain { get; set; } = string.Empty;

    /// <summary>
    /// 关键字
    /// </summary>
    public string Keyword { get; set; } = string.Empty;

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 联系 QQ
    /// </summary>
    public string Qq { get; set; } = string.Empty;

    /// <summary>
    /// LOGO 地址
    /// </summary>
    public string Logo { get; set; } = string.Empty;

    /// <summary>
    /// 深色 LOGO 地址
    /// </summary>
    public string LogoDark { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 更新人ID
    /// </summary>
    public long? UpdateUserId { get; set; }
}
