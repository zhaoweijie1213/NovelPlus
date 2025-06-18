# AGENTS.md

## 环境
- TargetFramework: **net9.0**

## 代码风格
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

novel-admin、novel-common、novel-crawl、novel-front、config、doc、templates文件夹为java源码

NovelPlus.sln为.NET解决方案

## 目标任务

需要将java项目转换为.NET 9项目，微服务架构，前端项目转换为vue，后端接口使用ASP.NET WebApi,ORM使用Sql Sugar,

