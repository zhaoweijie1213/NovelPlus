using Microsoft.AspNetCore.Mvc;
using UserService.Service.Application;
using UserService.Service.Domain.Entities;

namespace UserService.Host.Api.Controllers
{
    /// <summary>
    /// 用户接口
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        /// <summary>
        /// 构造函数
        /// </summary>
        public UsersController(IUserService service)
        {
            _service = service;
        }

        /// <summary>
        /// 获取全部用户
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        /// <summary>
        /// 根据ID获取用户
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<User?> GetById(int id)
        {
            var user = _service.GetById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
