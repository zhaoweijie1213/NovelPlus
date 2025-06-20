# 代码风格

- 使用 `dotnet format` 保证格式；命名遵循 **PascalCase**（类型/方法）和 **_camelCase**（私有字段）。
- 所有注释使用简体中文,除非是专业术语
- 不允许使用 `dynamic`，除非原因写进代码注释。
- 每个实体字段和方法需要写注释
- API返回结果必须定义强类型，不能是object，必须有明确的返回结构

## 构建 & 测试
1. `dotnet restore`
2. `dotnet build -c Release /warnaserror`
3. `dotnet test --collect:"XPlat Code Coverage"`

> 所有补丁必须在本地通过以上 3 步，且行覆盖率 **≥ 80%**。

## 质量检查
```bash
dotnet format --verify-no-changes
dotnet tool run dotnet-reportgenerator
```

## 说明

- java-code-source文件夹为java源码
- java-code-source/doc/sql为数据库表结构的原始SQL数据
- 本仓库是为了将java-code-source文件夹里的java源码重构成.NET项目
- Entities文件夹保存的是数据库实体声明，迁移时文件里的class定义可以复制到需要用的地方，不过文件名称需要加Entity后缀和注意命名空间的修改,还有string类型如果不是nullable需要声明默认值 string.Empty

### 每个.NET微服务模块的层次结构：    

####  \- WebApi 项目 `*.Host.Api`    

##### Api接口实例

```c#
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers
{
     /// <summary>
 /// 战队查询
 /// </summary>
 [Route("/api/v{version:apiVersion}/[controller]")]
 [Route("/api/[controller]")]
 [ApiController]
 [ApiVersion("1")]
 [ApiExplorerSettings(GroupName = "v1")]
 public class ClubQueryController : ControllerBase
 {
     /// <summary>
     /// 操作记录
     /// </summary>
     /// <param name="clubId"></param>
     /// <param name="pageIndex"></param>
     /// <param name="pageSize"></param>
     /// <returns></returns>
     [HttpGet("UserOperatorByPageAsync")]
     public async Task<ApiResult<UserOperatorOutput>> UserOperatorByPageAsync(int clubId, int pageIndex = 1, int 						pageSize = 30)
     {

     }
 }
}
    

```



####  \- Application 项目 `*.Service.Application`   

####  \- Domain 项目 `*.Service.Domain`   

####  \- Infrastructure 项目 `*.Service.Infrastructure` ORM使用SqlSugar

##### SqlSugar 仓储骨架示例

```c#
// Domain/Repositories/IBookRepository.cs
namespace NovelPlus.Domain.Repositories;
public interface IBookRepository : ITransientDependency
{
    public Task<List<UserEntity>> GetUsersPhoneAsync(long userId);
}

// Infrastructure/Repositories/BookRepository.cs
namespace NovelPlus.Infrastructure.Repositories;
public class BookRepository(ILogger<UserRepository> logger, IOptionsMonitor<DatabaseConfig> options) : BaseRepository<UserEntity>(logger, options.CurrentValue.NovelPlus) : IBookRepository
{
    /// <summary>
    /// 查询用户信息
    /// </summary>
    /// <param name="lastId"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    public Task<List<UserEntity>> GetUsersPhoneAsync(long userId)
    {
        return Db.Queryable<UserEntity>()
            .Where(i => i.Id == userId)
            .FirstAsync();
    }
}

```



## 层级职责与依赖

| 物理项目                         | 典型命名空间                                                 | 放哪些东西                                                   | 允许引用                       |
| -------------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------ |
| **<Svc>.Service.Domain**         | .Domain.Entities<br>.Domain.ValueObjects<br>.Domain.Events<br>.Domain.Services | - 领域实体（User、Book …）<br>- 值对象（Email, Money）<br>- 聚合根、领域服务接口<br>- 领域事件 / 不变式校验 | 仅 System.*                    |
| **<Svc>.Service.Application**    | .Application.Commands<br>.Application.Queries<br>.Application.Dtos<br>.Application.Handlers | - CQRS 命令 / 查询 & Handler<br>- Application Service<br>- DTO / ViewModel<br>- Repository & 其他接口定义 | Domain, Contracts              |
| **<Svc>.Service.Infrastructure** | .Infrastructure.Persistence<br>.Infrastructure.Repositories<br>.Infrastructure.Cache | - SqlSugar/EFCore 仓储实现<br>- EasyCaching/Redis、MessageBus 实现<br>- 迁移脚本 & Seed<br>- IoC 扩展方法 `Add<Svc>Infrastructure()` | Application, Domain, Contracts |
| **<Svc>.Host.Api**               | .Host.Controllers<br>.Host.Endpoints                         | - Minimal API / Controller<br>- Filters、认证、异常处理<br>- Swagger & 健康检查<br>- `Program.cs / Startup.cs` | Application, Contracts         |

> **依赖方向必须单向向内**：Host.Api → Application → Domain；Infrastructure 反向实现接口，但**不得被引用**。

### java项目源码与.NET项目的对应关系

java-code-source/novel-admin → src/Admin

java-code-source/novel-crawl → src/Crawler

java-code-source/novel-front → src/Portal

### 代码规范/约定

1. 将java代码迁移到.NET时需要严格按照项目对应的关系迁移
2. 公共help类、util等放在src/Shared项目里,
3. entity实体必须放在项目各自的Domain层，就算用的同一个数据库表也不能提取到Shared项目,而是各自在Domain里声明Entity
4. api接口统一使用ApiResult<T>返回格式，命名空间为using QYQ.Base.Common.ApiResult;
5. API返回的定义使用 {xxx}Output统一后缀 例如：UserOutput ,统一放在*Application*层 的Output文件夹
6. 复杂请求参数需要定义class 名称为 {xxx}Input 后缀 例如：UserInput,统一放在*Application*层 的Input文件夹



