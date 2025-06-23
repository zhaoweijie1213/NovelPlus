using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 订单服务接口
/// </summary>
public interface IOrderService : IScopeDependency
{
    /// <summary>
    /// 创建充值订单
    /// </summary>
    Task<long> CreatePayOrderAsync(byte payChannel, int payAmount, long userId);
}
