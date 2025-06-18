using EasyCaching.Core;

namespace BuildingBlocks.Common.Caching;

/// <summary>
/// Redis缓存实现
/// </summary>
public class RedisCacheService : ICacheService
{
    private readonly IEasyCachingProvider _provider;

    /// <summary>
    /// 构造函数
    /// </summary>
    public RedisCacheService(IEasyCachingProvider provider)
    {
        _provider = provider;
    }

    /// <inheritdoc />
    public async Task<T?> GetAsync<T>(string key)
    {
        var result = await _provider.GetAsync<T>(key);
        return result.HasValue ? result.Value : default;
    }

    /// <inheritdoc />
    public Task SetAsync<T>(string key, T value, TimeSpan? expire = null)
    {
        return _provider.SetAsync(key, value, expire ?? TimeSpan.FromMinutes(5));
    }
}
