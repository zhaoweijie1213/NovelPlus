using Microsoft.Extensions.Caching.Memory;
using NovelPlus.Portal.Service.Application.Interfaces;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 缓存服务实现
/// </summary>
public class CacheService(IMemoryCache cache) : ICacheService
{
    private readonly IMemoryCache _cache = cache;

    /// <inheritdoc/>
    public string? Get(string key) => _cache.Get<string>(key);

    /// <inheritdoc/>
    public void Set(string key, string value, long? timeout = null)
    {
        if (timeout.HasValue)
            _cache.Set(key, value, TimeSpan.FromSeconds(timeout.Value));
        else
            _cache.Set(key, value);
    }

    /// <inheritdoc/>
    public object? GetObject(string key) => _cache.Get(key);

    /// <inheritdoc/>
    public void SetObject(string key, object value, long? timeout = null)
    {
        if (timeout.HasValue)
            _cache.Set(key, value, TimeSpan.FromSeconds(timeout.Value));
        else
            _cache.Set(key, value);
    }

    /// <inheritdoc/>
    public void Del(string key) => _cache.Remove(key);

    /// <inheritdoc/>
    public bool Contains(string key) => _cache.TryGetValue(key, out _);

    /// <inheritdoc/>
    public void Expire(string key, long timeout)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            _cache.Set(key, value, TimeSpan.FromSeconds(timeout));
        }
    }
}
