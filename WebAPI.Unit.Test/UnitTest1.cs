using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;
using WebAPI.Services;
using Xunit;

namespace WebAPI.Unit.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetFruitIsNotEmpty()
        {
            FruitService service = new();

            IEnumerable<Fruit> result = service.GetFruit();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetFruitNumberOfItems()
        {
            FruitService service = new();

            IEnumerable<Fruit> result = service.GetFruit();

            Assert.Equal(5, result.Count());
        }


    }
}
