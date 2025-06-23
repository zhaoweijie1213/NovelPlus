using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 订单仓储接口
/// </summary>
public interface IOrderRepository : ITransientDependency
{
    /// <summary>
    /// 新增充值订单
    /// </summary>
    Task<int> SaveAsync(OrderPayEntity order);
}
