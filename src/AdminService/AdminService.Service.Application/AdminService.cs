using System;
using System.Collections.Generic;
using System.Linq;
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
        new AdminUser { UserId = 1, Username = "admin", Name = "管理员" }
    };

    /// <inheritdoc />
    public IEnumerable<AdminUser> GetAll() => _admins;

    /// <inheritdoc />
    public AdminUser? GetById(long id) => _admins.FirstOrDefault(a => a.UserId == id);

    /// <inheritdoc />
    public IEnumerable<AdminUser> List(IDictionary<string, object> filters) => _admins;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _admins.Count;

    /// <inheritdoc />
    public int Save(AdminUser admin)
    {
        admin.UserId = _admins.Max(a => a.UserId) + 1;
        _admins.Add(admin);
        return 1;
    }

    /// <inheritdoc />
    public int Update(AdminUser admin)
    {
        var index = _admins.FindIndex(a => a.UserId == admin.UserId);
        if (index == -1) return 0;
        _admins[index] = admin;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var admin = _admins.FirstOrDefault(a => a.UserId == id);
        if (admin == null) return 0;
        _admins.Remove(admin);
        return 1;
    }

    /// <inheritdoc />
    public int BatchRemove(long[] ids)
    {
        var removed = 0;
        foreach (var id in ids) removed += Remove(id);
        return removed;
    }

    /// <inheritdoc />
    public IDictionary<object, object> TableStat(DateTime minDate)
    {
        return new Dictionary<object, object>();
    }
}
