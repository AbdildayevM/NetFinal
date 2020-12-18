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
    public class UserServiceTest
    {
        [Fact]
        public async Task GetClientsTest()
        {
            var clients = new List<User>
            {
                new User() { ID = 1, LastName = "Aa", FirstName = "A", Password = "qwerty", PhoneNumber = 87477477474, SignDate = new DateTime(2020, 12, 12) },
                new User() { FirstName = "F" },
            };

            var fakeRepositoryMock = new Mock<IUserRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(clients);


            var userService = new UsersService(fakeRepositoryMock.Object);

            var resultUsers = await userService.GetUsers();

            Assert.Collection(resultUsers, user =>
            {
                Assert.Equal(1, user.ID);
            },
            user =>
            {
                Assert.Equal("F", user.FirstName);
            });
        }
    }
}
