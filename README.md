# NovelPlus .NET Migration

该项目正在将 Java 版 `novel-plus` 系统迁移到 .NET 9 微服务架构，当前已完成管理员、爬虫与门户模块的基础框架。每个模块按照 *Host.Api*、*Service.Application*、*Service.Domain* 与 *Service.Infrastructure* 的分层结构组织，仅声明接口和实体，暂未实现具体业务逻辑。

## 构建
```bash
dotnet restore
dotnet build -c Release /warnaserror
dotnet test --collect:"XPlat Code Coverage"
```

## 代码格式化
```bash
dotnet format --verify-no-changes
```
