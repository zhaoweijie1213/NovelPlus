using Microsoft.Extensions.Caching.Memory;
using NovelPlus.Portal.Service.Application.Interfaces;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 缓存服务实现
/// </summary>
public class CacheService(IMemoryCache cache) : ICacheService
{
    private readonly IMemoryCache _cache = cache;

    /// <summary>
    /// 获取指定键的缓存字符串
    /// </summary>
    /// <param name="key">缓存键</param>
    /// <returns>缓存内容或 null</returns>
    public string? Get(string key) => _cache.Get<string>(key);

    /// <summary>
    /// 设置字符串缓存
    /// </summary>
    /// <param name="key">缓存键</param>
    /// <param name="value">缓存值</param>
    /// <param name="timeout">过期时间（秒）</param>
    public void Set(string key, string value, long? timeout = null)
    {
        if (timeout.HasValue)
            _cache.Set(key, value, TimeSpan.FromSeconds(timeout.Value));
        else
            _cache.Set(key, value);
    }

    /// <summary>
    /// 获取对象缓存
    /// </summary>
    /// <param name="key">缓存键</param>
    /// <returns>缓存对象或 null</returns>
    public object? GetObject(string key) => _cache.Get(key);

    /// <summary>
    /// 设置对象缓存
    /// </summary>
    /// <param name="key">缓存键</param>
    /// <param name="value">缓存对象</param>
    /// <param name="timeout">过期时间（秒）</param>
    public void SetObject(string key, object value, long? timeout = null)
    {
        if (timeout.HasValue)
            _cache.Set(key, value, TimeSpan.FromSeconds(timeout.Value));
        else
            _cache.Set(key, value);
    }

    /// <summary>
    /// 删除缓存
    /// </summary>
    /// <param name="key">缓存键</param>
    public void Del(string key) => _cache.Remove(key);

    /// <summary>
    /// 判断缓存是否存在
    /// </summary>
    /// <param name="key">缓存键</param>
    /// <returns>存在返回 true</returns>
    public bool Contains(string key) => _cache.TryGetValue(key, out _);

    /// <summary>
    /// 修改缓存过期时间
    /// </summary>
    /// <param name="key">缓存键</param>
    /// <param name="timeout">新过期时间（秒）</param>
    public void Expire(string key, long timeout)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            _cache.Set(key, value, TimeSpan.FromSeconds(timeout));
        }
    }
}
