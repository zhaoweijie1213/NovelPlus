namespace NovelPlus.Crawler.Service.Domain.Services;

/// <summary>
/// 爬虫 HTTP 客户端
/// </summary>
public interface ICrawlHttpClient
{
    /// <summary>
    /// 发送 GET 请求
    /// </summary>
    /// <param name="url">请求地址</param>
    /// <param name="charset">字符编码</param>
    /// <returns>网页内容</returns>
    Task<string?> GetAsync(string url, string charset);
}
