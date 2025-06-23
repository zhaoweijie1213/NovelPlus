using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Crawler.Service.Domain.Config;
using NovelPlus.Crawler.Service.Domain.Services;

namespace NovelPlus.Crawler.Service.Infrastructure.Services;

/// <summary>
/// 默认的爬虫 HTTP 客户端实现
/// </summary>
public class CrawlHttpClient(ILogger<CrawlHttpClient> logger,
    IHttpClientFactory httpClientFactory,
    IOptions<CrawlOptions> options) : ICrawlHttpClient
{
    private readonly ILogger<CrawlHttpClient> _logger = logger;
    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;
    private readonly CrawlOptions _options = options.Value;
    private readonly Random _random = new();

    /// <inheritdoc />
    public async Task<string?> GetAsync(string url, string charset)
    {
        for (var i = 0; i < _options.RetryCount; i++)
        {
            if (_options.IntervalMax > _options.IntervalMin)
            {
                var delay = _random.Next(_options.IntervalMin, _options.IntervalMax + 1);
                await Task.Delay(delay);
            }

            try
            {
                using var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    continue;
                }

                var bytes = await response.Content.ReadAsByteArrayAsync();
                var content = System.Text.Encoding.GetEncoding(charset).GetString(bytes);
                if (content.Length < _options.InvalidHtmlLength)
                {
                    continue;
                }

                return content;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "请求失败:{Url}", url);
            }
        }

        return null;
    }
}
