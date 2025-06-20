using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 用户反馈仓储接口
/// </summary>
public interface IUserFeedbackRepository
{
    Task<UserFeedbackEntity?> GetAsync(long id);

    Task<List<UserFeedbackEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(UserFeedbackEntity feedback);

    Task<int> UpdateAsync(UserFeedbackEntity feedback);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
