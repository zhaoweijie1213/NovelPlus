using System.Collections.Generic;
using AdminService.Service.Domain.Entities;

namespace AdminService.Service.Application;

/// <summary>
/// 管理员业务接口
/// </summary>
public interface IAdminService
{
    /// <summary>
    /// 获取管理员列表
    /// </summary>
    IEnumerable<AdminUser> GetAll();
}
