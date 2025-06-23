# 代码风格

- 使用 `dotnet format` 保证格式；命名遵循 **PascalCase**（类型/方法）和 **_camelCase**（私有字段）。
- 不允许使用 `dynamic`，除非原因写进代码注释。
- 每个实体字段和方法必须要写注释.，所有注释使用简体中文,除非是专业术语
- API返回结果必须定义强类型，不能是object，必须有明确的返回结构
- 实体的主键不能是nullable类型
- int 、 long 等代表数量的类型不能是nullable类型

## 构建 & 测试
1. `dotnet restore`
2. `dotnet build -c Release /warnaserror`
3. `dotnet test --collect:"XPlat Code Coverage"`

> 所有补丁必须在本地通过以上 3 步，且行覆盖率 **≥ 80%**。

## 质量检查

先检测是否所有方法和属性都有注释,如果没有则补充完善,然后进行质量检查

```bash
dotnet format --verify-no-changes
dotnet tool run dotnet-reportgenerator
```

## README更新

质量检查完成后，根据现在重构的程度完善项目根目录的README.md文件，需要加上本次说明的时间(北京时间)节点 yyyy-MM-dd HH:mm:ss 。README.md文件里记录程序的结构情况和基本的功能，暂时不做其他说明

## 说明

- java-code-source文件夹为java源码
- java-code-source/doc/sql为数据库表结构的原始SQL数据
- 本仓库是为了将java-code-source文件夹里的java源码重构成.NET项目
- Entities文件夹保存的是数据库实体声明，迁移时文件里的class定义可以复制到需要用的地方，不过文件名称需要加Entity后缀和注意命名空间的修改,还有string类型如果不是nullable需要声明默认值 string.Empty
- API接口声明已经完成,目前的重构阶段已经涉及具体的业务逻辑。

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

| 物理项目                         | 典型命名空间                                                 | 主要存放内容                                                 | 允许引用                                  |
| -------------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ----------------------------------------- |
| **<Svc>.Service.Domain**         | `.Domain.Entities`  `.Domain.ValueObjects` `.Domain.Repositories` `.Domain.Events` `.Domain.Services` | - **实体 / 聚合根**（`Book`、`User`…）- **值对象**（`Email`、`Money`…）- **仓储接口**（`IBookRepository`…）- 领域服务接口 & 不变式校验- 领域事件 | 仅 **System.\***                          |
| **<Svc>.Service.Application**    | `.Application.Commands` `.Application.Queries` `.Application.Dtos` `.Application.Handlers` `.Application.Services` | - CQRS **命令 / 查询** 与 **Handler**（MediatR）- 应用服务 / 用例编排- DTO / ViewModel- 横切接口（如 `IDateTime`） | **Domain**, Contracts*                    |
| **<Svc>.Service.Infrastructure** | `.Infrastructure.Persistence` `.Infrastructure.Repositories` `.Infrastructure.Cache` `.Infrastructure.Messaging` | - **SqlSugar** 仓储实现- Redis / MessageBus 等适配器- 迁移脚本、Seed 数据- IoC 扩展 `Add<Svc>Infrastructure()` | **Domain**, Application (可选), Contracts |
| **<Svc>.Host.Api**               | `.Host.Controllers` `.Host.Endpoints`                        | - Controller / Minimal API- 认证、异常过滤器- Swagger、健康检查- `Program.cs` / `Startup.cs` | **Application**, Contracts                |

\* **Contracts**：可选的 *<Svc>.Service.Contracts* 项目，专门放 `CreateBookRequest`, `BookResponse` 等 API 公开模型；若项目简单，也可直接放在 Application，目前的项目比较简单，不需要这一层。

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
7. 聚合根命名规定为 默认使用 **纯领域名**，不加后缀：`Order.cs`, `Book.cs`, `User.cs` 文件位于 `Domain.Aggregates` 等命名空间



