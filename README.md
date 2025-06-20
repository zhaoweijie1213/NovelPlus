# NovelPlus .NET Migration

该项目正在将 Java 版 `novel-plus` 系统迁移到 .NET 9 微服务架构，目前已完成管理员模块的基础框架，包括 API 控制器与服务接口的声明。

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
