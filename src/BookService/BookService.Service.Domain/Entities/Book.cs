namespace BookService.Service.Domain.Entities;

/// <summary>
/// 书籍实体
/// </summary>
public class Book
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 书名
    /// </summary>
    public string Title { get; set; } = string.Empty;
}
