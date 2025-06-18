using UserService.Core.Entities;

namespace UserService.Core
{
    /// <summary>
    /// 用户业务接口
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 获取全部用户
        /// </summary>
        /// <returns>用户列表</returns>
        IEnumerable<User> GetAll();

        /// <summary>
        /// 通过ID获取用户
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns>用户实体</returns>
        User? GetById(int id);
    }
}
