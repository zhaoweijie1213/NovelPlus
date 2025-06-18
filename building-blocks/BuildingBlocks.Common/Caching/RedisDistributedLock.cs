namespace BuildingBlocks.Common.Caching;

/// <summary>
/// Redis分布式锁（示例实现）
/// </summary>
public class RedisDistributedLock : IDistributedLock
{
    private readonly SemaphoreSlim _lock = new(1, 1);

    /// <inheritdoc />
    public async Task<bool> AcquireAsync(string key, TimeSpan expire)
    {
        return await _lock.WaitAsync(expire);
    }

    /// <inheritdoc />
    public Task ReleaseAsync(string key)
    {
        _lock.Release();
        return Task.CompletedTask;
    }
}
