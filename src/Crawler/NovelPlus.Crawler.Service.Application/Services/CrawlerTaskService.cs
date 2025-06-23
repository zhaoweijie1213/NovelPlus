using Quartz;
using Quartz.Impl;
using System.Collections.Specialized;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Services;
using QYQ.Base.Common.IOCExtensions;

namespace NovelPlus.Crawler.Service.Application.Services;

/// <summary>
/// 爬虫任务服务，提供任务的创建、启动、暂停与停止功能。
/// </summary>
public class CrawlerTaskService : IScopeDependency
{
    /// <summary>
    /// 调度器实例
    /// </summary>
    private readonly IScheduler _scheduler;

    /// <summary>
    /// 构造函数，初始化调度器并注册解析器。
    /// </summary>
    public CrawlerTaskService(CrawlParser parser, IConfiguration configuration)
    {
        var conn = configuration.GetConnectionString("NovelPlus");
        StdSchedulerFactory factory;
        if (string.IsNullOrEmpty(conn))
        {
            factory = new StdSchedulerFactory();
        }
        else
        {
            var props = new NameValueCollection
            {
                ["quartz.scheduler.instanceName"] = "CrawlerScheduler",
                ["quartz.serializer.type"] = "json",
                ["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz",
                ["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.MySQLDelegate, Quartz",
                ["quartz.jobStore.tablePrefix"] = "QRTZ_",
                ["quartz.jobStore.dataSource"] = "default",
                ["quartz.dataSource.default.provider"] = "MySqlConnector",
                ["quartz.dataSource.default.connectionString"] = conn,
            };
            factory = new StdSchedulerFactory(props);
        }

        _scheduler = factory.GetScheduler().Result;
        _scheduler.Context.Add("parser", parser);
    }

    /// <summary>
    /// 创建并调度一个新的爬虫任务。
    /// </summary>
    /// <param name="taskId">任务标识</param>
    /// <param name="rule">解析规则</param>
    /// <param name="bookId">站点书籍编号</param>
    /// <returns>任务键</returns>
    public async Task<JobKey> CreateTaskAsync(string taskId, RuleBean rule, string bookId)
    {
        var job = JobBuilder.Create<CrawlJob>()
            .WithIdentity(taskId)
            .UsingJobData("rule", JsonSerializer.Serialize(rule))
            .UsingJobData("bookId", bookId)
            .Build();

        var trigger = TriggerBuilder.Create()
            .StartNow()
            .Build();

        await _scheduler.ScheduleJob(job, trigger);
        return job.Key;
    }

    /// <summary>
    /// 启动调度器。
    /// </summary>
    public Task StartAsync() => _scheduler.Start();

    /// <summary>
    /// 暂停指定任务。
    /// </summary>
    /// <param name="key">任务键</param>
    public Task PauseAsync(JobKey key) => _scheduler.PauseJob(key);

    /// <summary>
    /// 恢复指定任务。
    /// </summary>
    /// <param name="key">任务键</param>
    public Task ResumeAsync(JobKey key) => _scheduler.ResumeJob(key);

    /// <summary>
    /// 停止调度器并释放资源。
    /// </summary>
    public Task StopAsync() => _scheduler.Shutdown();
}
