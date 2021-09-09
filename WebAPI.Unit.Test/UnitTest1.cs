using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;
using WebAPI.Repositories;
using WebAPI.Services;
using Xunit;

namespace WebAPI.Unit.Test
{
    public class UnitTest1
    {

        [Fact]
        public void GetFruitIsNotEmpty()
        {
            Mock<IRepository<Fruit>> mockRepo = new Mock<IRepository<Fruit>>();
            mockRepo.Setup(x => x.Get()).Returns(new List<Fruit> { new Fruit(1, "Apple", "An apple is a type of fruit that is grown on an apple tree.", ""), new Fruit(3, "Mango", "A Mango", "")});

            FruitService service = new(mockRepo.Object);

            IEnumerable<Fruit> result = service.GetFruit();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetFruitNumberOfItems()
        {
            Mock<IRepository<Fruit>> mockRepo = new Mock<IRepository<Fruit>>();
            mockRepo.Setup(x => x.Get()).Returns(new List<Fruit> 
            { 
               new Fruit(1, "Apple", "An apple is a type of fruit that is grown on an apple tree.", ""),
               new Fruit(2, "Pear", "Like apples, to which they are related, pears come in thousands of varieties, of which only a small fraction are sold in the UK.", ""),
               new Fruit(3, "Mango", "A Mango", ""),
               new Fruit(4, "Strawberry", "juicy edible usually red fruit of any of several low-growing temperate herbs (genus Fragaria) of the rose family that is technically an enlarged pulpy receptacle bearing numerous achenes on its surface.", ""),
               new Fruit(5, "Nectarine", "smooth-skinned peach of the family Rosaceae that is grown throughout the warmer temperate regions of both the Northern and Southern hemispheres.", ""),
            });

            FruitService service = new(mockRepo.Object);

            IEnumerable<Fruit> result = service.GetFruit();

            Assert.Equal(5, result.Count());
        }


    }
}
