using PayService.Service.Application;
using Xunit;

namespace PayService.Tests;

public class OrderServiceTests
{
    [Fact]
    public void GetAll_ReturnsOrders()
    {
        IOrderService service = new PayService.Service.Application.OrderService();
        var orders = service.GetAll().ToList();
        Assert.Single(orders);
        Assert.Equal(99, orders[0].TotalAmount);
    }
}
