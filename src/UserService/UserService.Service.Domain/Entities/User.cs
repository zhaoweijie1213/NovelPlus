using System;
using System.ComponentModel.DataAnnotations;

namespace UserService.Service.Domain.Entities
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class User
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        [Required]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; } = string.Empty;

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 用户头像
        /// </summary>
        public string UserPhoto { get; set; } = string.Empty;

        /// <summary>
        /// 用户性别，0：男，1：女
        /// </summary>
        public int UserSex { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        public long AccountBalance { get; set; }

        /// <summary>
        /// 用户状态，0：正常
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
    }
}
