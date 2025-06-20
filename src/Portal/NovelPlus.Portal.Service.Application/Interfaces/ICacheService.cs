using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 缓存服务
/// </summary>
public interface ICacheService
{
    /// <summary>
    /// 根据key获取字符串
    /// </summary>
    string? Get(string key);

    /// <summary>
    /// 设置字符串缓存
    /// </summary>
    void Set(string key, string value, long? timeout = null);

    /// <summary>
    /// 获取对象缓存
    /// </summary>
    object? GetObject(string key);

    /// <summary>
    /// 设置对象缓存
    /// </summary>
    void SetObject(string key, object value, long? timeout = null);

    /// <summary>
    /// 删除缓存
    /// </summary>
    void Del(string key);

    /// <summary>
    /// 判断是否存在
    /// </summary>
    bool Contains(string key);

    /// <summary>
    /// 设置过期时间
    /// </summary>
    void Expire(string key, long timeout);
}
