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
    public class FoodServiceTest
    {
        [Fact]
        public async Task GetFoodsTest()
        {
            var foods = new List<Food>
            {
                new Food() { FoodID = 1},
                new Food() { Title = "Pizza" },
            };

            var fakeRepositoryMock = new Mock<IFoodRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(foods);


            var foodService = new FoodService(fakeRepositoryMock.Object);

            var resultFoods = await foodService.GetFoods();

            Assert.Collection(resultFoods, food =>
            {
                Assert.Equal(1, food.FoodID);
            },
            food =>
            {
                Assert.Equal("Pizza", food.Title);
            });
        }
    }
}
