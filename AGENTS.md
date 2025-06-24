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

先检测是否所有方法和属性都有注释,如果没有则补充完善,然后进行质量检查(注释必须描述属性的作用、方法的功能,不能敷衍)

```bash
dotnet format --verify-no-changes
dotnet tool run dotnet-reportgenerator
```

## README更新

质量检查完成后，根据现在重构的程度完善项目根目录的README.md文件，需要加上本次说明的时间(北京时间)节点 yyyy-MM-dd HH:mm:ss 。README.md文件里记录程序的结构情况和基本的功能，还需要说明使用的技术栈

## 说明

- java-code-source文件夹为java源码
- novel-plus-vue对应了ava-code-source\novel-front模块的前端代码
- 本仓库是为了将java-code-source文件夹里的java源码重构成.NET Web Api + vuetify项目

### java项目源码与.NET项目的对应关系

java-code-source/novel-admin → src/Admin

java-code-source/novel-crawl → src/Crawler

java-code-source/novel-front → src/Portal

### 后端代码规范/约定

1. 将java代码迁移到.NET时需要严格按照项目对应的关系迁移
2. 公共help类、util等放在src/Shared项目里,
3. entity实体必须放在项目各自的Domain层，就算用的同一个数据库表也不能提取到Shared项目,而是各自在Domain里声明Entity
4. api接口统一使用ApiResult<T>返回格式，命名空间为using QYQ.Base.Common.ApiResult;
5. API返回的定义使用 {xxx}Output统一后缀 例如：UserOutput ,统一放在*Application*层 的Output文件夹
6. 复杂请求参数需要定义class 名称为 {xxx}Input 后缀 例如：UserInput,统一放在*Application*层 的Input文件夹
7. 聚合根命名规定为 默认使用 **纯领域名**，不加后缀：`Order.cs`, `Book.cs`, `User.cs` 文件位于 `Domain.Aggregates` 等命名空间
8. 缓存使用redis，nuget使用easycaching
9. 使用Mapster来简化对象map
10. 依赖注入使用主构造函数的写法,实例化新对象可以使用new()等c#新写法
11. 单元测试使用IClassFixture<WebApplicationFactory<Program>>来实现依赖注入
