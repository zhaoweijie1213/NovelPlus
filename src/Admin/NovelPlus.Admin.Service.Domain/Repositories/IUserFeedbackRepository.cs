using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 用户反馈仓储接口
/// </summary>
public interface IUserFeedbackRepository
{
    /// <summary>
    /// 查询反馈
    /// </summary>
    Task<UserFeedbackEntity?> GetAsync(long id);

    /// <summary>
    /// 反馈列表
    /// </summary>
    Task<List<UserFeedbackEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 反馈数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增反馈
    /// </summary>
    Task<int> SaveAsync(UserFeedbackEntity feedback);

    /// <summary>
    /// 更新反馈
    /// </summary>
    Task<int> UpdateAsync(UserFeedbackEntity feedback);

    /// <summary>
    /// 删除反馈
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除反馈
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
