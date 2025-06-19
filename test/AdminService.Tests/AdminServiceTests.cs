using AdminService.Service.Application;
using Xunit;

namespace AdminService.Tests;

public class AdminServiceTests
{
    [Fact]
    public void GetAll_ReturnsAdmins()
    {
        IAdminService service = new AdminService.Service.Application.AdminService();
        var admins = service.GetAll().ToList();
        Assert.Single(admins);
        Assert.Equal("admin", admins[0].Username);
    }
}
