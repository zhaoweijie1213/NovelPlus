# 代码风格

- 使用 `dotnet format` 保证格式；命名遵循 **PascalCase**（类型/方法）和 **_camelCase**（私有字段）。
- 所有注释使用简体中文,除非是专业术语
- 不允许使用 `dynamic`，除非原因写进代码注释。
- 每个实体字段和方法需要写注释

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

java-code-source文件夹为java源码

NovelPlus.sln为.NET解决方案

本仓库是为了将java-code-source文件夹里的java源码转换成.NET项目

大任务拆分为多个子任务分步完成

每个微服务模块的层次结构：    

 \- WebApi 项目 `*.Host.Api`    

 \- Application 项目 `*.Service.Application`   

 \- Domain 项目 `*.Service.Domain`   

 \- Infrastructure 项目 `*.Service.Infrastructure` 

## 层级职责与依赖

| 物理项目                         | 典型命名空间                                                 | 放哪些东西                                                   | 允许引用                       |
| -------------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------ |
| **<Svc>.Service.Domain**         | .Domain.Entities<br>.Domain.ValueObjects<br>.Domain.Events<br>.Domain.Services | - 领域实体（User、Book …）<br>- 值对象（Email, Money）<br>- 聚合根、领域服务接口<br>- 领域事件 / 不变式校验 | 仅 System.*                    |
| **<Svc>.Service.Application**    | .Application.Commands<br>.Application.Queries<br>.Application.Dtos<br>.Application.Handlers | - CQRS 命令 / 查询 & Handler<br>- Application Service<br>- DTO / ViewModel<br>- Repository & 其他接口定义 | Domain, Contracts              |
| **<Svc>.Service.Infrastructure** | .Infrastructure.Persistence<br>.Infrastructure.Repositories<br>.Infrastructure.Cache | - SqlSugar/EFCore 仓储实现<br>- EasyCaching/Redis、MessageBus 实现<br>- 迁移脚本 & Seed<br>- IoC 扩展方法 `Add<Svc>Infrastructure()` | Application, Domain, Contracts |
| **<Svc>.Host.Api**               | .Host.Controllers<br>.Host.Endpoints                         | - Minimal API / Controller<br>- Filters、认证、异常处理<br>- Swagger & 健康检查<br>- `Program.cs / Startup.cs` | Application, Contracts         |

> **依赖方向必须单向向内**：Host.Api → Application → Domain；Infrastructure 反向实现接口，但**不得被引用**。

