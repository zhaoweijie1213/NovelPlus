namespace BuildingBlocks.Common.Caching;

/// <summary>
/// 分布式锁接口
/// </summary>
public interface IDistributedLock
{
    /// <summary>
    /// 获取锁
    /// </summary>
    Task<bool> AcquireAsync(string key, TimeSpan expire);

    /// <summary>
    /// 释放锁
    /// </summary>
    Task ReleaseAsync(string key);
}
