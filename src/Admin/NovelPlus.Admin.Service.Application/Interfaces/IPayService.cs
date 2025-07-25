using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 充值订单服务接口
/// </summary>
public interface IPayService
{
    Task<OrderPayEntity?> GetAsync(long id);

    Task<List<OrderPayEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(OrderPayEntity order);

    Task<int> UpdateAsync(OrderPayEntity order);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);

    Task<Dictionary<object, object>> TableStaAsync(DateTime minDate);
}
