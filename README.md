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
- 门户模块现包含用户、小说、支付等接口及缓存管理接口，新增小说、首页设置、新闻、书架、阅读记录、用户以及评论等仓储接口，实体和服务均已迁移到对应层。
- 管理后台模块已补充所有仓储实现，使用 SqlSugar 完成基础 CRUD 与统计操作。
- 爬虫模块新增小说及目录仓储接口，提供待更新小说查询和最后章节获取等功能。
- 2025-06-23 02:55:58 爬虫模块完善仓储实现，新增查询字数与更新时间接口。
- 2025-06-23 03:03:49 补充仓储层注释并通过最新质量检查。
- 2025-06-23 03:14:53 门户模块补充仓储实现，完善基础查询与更新功能。
