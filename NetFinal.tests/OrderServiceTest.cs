using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NetFinal.Models;
using NetFinal.Services;
using NetFinal.Repositories;
using System.Threading.Tasks;
using Moq;

namespace NetFinal.tests
{
    public class OrderServiceTest
    {
        [Fact]
        public async Task GetOrdersTest()
        {
            var orders = new List<Order>
            {
                new Order() { ID = 1  },
                new Order() { Address = "Manas" },
            };

            var fakeRepositoryMock = new Mock<IOrderRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(orders);


            var orderService = new OrderService(fakeRepositoryMock.Object);

            var resultOrders = await orderService.GetOrders();

            Assert.Collection(resultOrders, order =>
            {
                Assert.Equal(1, order.ID);
            },
            order =>
            {
                Assert.Equal("Manas", order.Address);
            });
        }
    }
}
