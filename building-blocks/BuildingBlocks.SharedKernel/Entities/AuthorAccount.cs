namespace BuildingBlocks.SharedKernel.Entities;

/// <summary>
/// 作者账户实体
/// </summary>
public class AuthorAccount
{
    /// <summary>
    /// 作者ID
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    public string NickName { get; set; } = string.Empty;
}
