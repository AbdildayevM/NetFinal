using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using  NetFinal.Models;


namespace NetFinal.tests.Models
{
    public class ConstructorsTests
    {
        [Fact]
        public void testCartConstructor()
        {
            User c = new User(1, "L", "F", 84744748888, "asfasrf",  new  DateTime(2020, 1, 1));
            Food f = new Food(1, "Pizza", 545);
            News n = new News(1, "New Pizza", "adjfvbakjdf vaj vajnfd vajhdf vakhfdbvafjvkasnf vk ");
            Order o = new Order(1, 1, 1, "Manasa 5", 4, 2180, new DateTime(2020, 1, 1));
            Partners p = new Partners(1, "Pazzini", "Delicious", "afvadfvadfvadf");

        }
    }
}
