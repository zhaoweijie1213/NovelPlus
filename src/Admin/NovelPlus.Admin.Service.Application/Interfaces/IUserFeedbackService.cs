using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 用户反馈服务接口
/// </summary>
public interface IUserFeedbackService
{
    Task<UserFeedbackEntity?> GetAsync(long id);

    Task<List<UserFeedbackEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(UserFeedbackEntity feedback);

    Task<int> UpdateAsync(UserFeedbackEntity feedback);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
