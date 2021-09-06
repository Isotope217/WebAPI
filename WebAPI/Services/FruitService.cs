using System;
using System.Collections.Generic;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public class FruitService : IFruitService
    {
        public IEnumerable<Fruit> GetFruit()
        {
            IEnumerable<Fruit> fruit = new List<Fruit>
            {
               new Fruit(1, "Apple123", "An apple is a type of fruit that is grown on an apple tree.", ""),
               new Fruit(2, "Pear", "Like apples, to which they are related, pears come in thousands of varieties, of which only a small fraction are sold in the UK.", ""),
               new Fruit(3, "Mango", "A Mango", ""),
               new Fruit(4, "Strawberry", "juicy edible usually red fruit of any of several low-growing temperate herbs (genus Fragaria) of the rose family that is technically an enlarged pulpy receptacle bearing numerous achenes on its surface.", ""),
               new Fruit(5, "Nectarine", "smooth-skinned peach of the family Rosaceae that is grown throughout the warmer temperate regions of both the Northern and Southern hemispheres.", ""),
            };

            return fruit;
        }
    }
}
