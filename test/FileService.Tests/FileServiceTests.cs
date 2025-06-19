using FileService.Service.Application;
using Xunit;

namespace FileService.Tests;

public class FileServiceTests
{
    [Fact]
    public void GetAll_ReturnsFiles()
    {
        IFileService service = new FileService.Service.Application.FileService();
        var files = service.GetAll().ToList();
        Assert.Single(files);
        Assert.Equal("demo.txt", files[0].Url);
    }
}
