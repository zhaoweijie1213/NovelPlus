using System.Collections.Generic;
using AdminService.Service.Domain.Entities;

namespace AdminService.Service.Application;

/// <summary>
/// 管理员业务实现
/// </summary>
public class AdminService : IAdminService
{
    /// <summary>
    /// 示例管理员列表
    /// </summary>
    private readonly List<AdminUser> _admins = new()
    {
        new AdminUser { Id = 1, UserName = "admin" }
    };

    /// <inheritdoc />
    public IEnumerable<AdminUser> GetAll() => _admins;
}
