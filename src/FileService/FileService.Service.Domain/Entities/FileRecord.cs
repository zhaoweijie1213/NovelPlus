namespace FileService.Service.Domain.Entities;

/// <summary>
/// 文件记录实体
/// </summary>
public class FileRecord
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 文件名
    /// </summary>
    public string FileName { get; set; } = string.Empty;
}
