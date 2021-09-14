using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Repositories
{
    public class FruitRespository : IRepository<Fruit>
    {
        public IEnumerable<Fruit> Get()
        {
            IEnumerable<Fruit> fruit = new List<Fruit>
            {
               new Fruit(1, "Apple", "An apple is a type of fruit that is grown on an apple tree.", "http://justfunfacts.com/wp-content/uploads/2015/11/apple.jpg", 1.00m),
               new Fruit(2, "Pear", "Like apples, to which they are related, pears come in thousands of varieties, of which only a small fraction are sold in the UK.", "https://walcotnursery.co.uk/wp-content/uploads/2017/07/shutterstock_555872428-300x366.jpg", 0.80m),
               new Fruit(3, "Mango", "A Mango", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTU2g3OCguvmfwyKWznkXp0lyvxT2_6o_b91A&usqp=CAU", 2.10m),
               new Fruit(4, "Strawberry", "juicy edible usually red fruit of any of several low-growing temperate herbs (genus Fragaria) of the rose family that is technically an enlarged pulpy receptacle bearing numerous achenes on its surface.", "https://allmanhall.co.uk/wp-content/uploads/2019/06/Strawberries-on-white-background.jpg", 0.20m),
               new Fruit(5, "Nectarine", "smooth-skinned peach of the family Rosaceae that is grown throughout the warmer temperate regions of both the Northern and Southern hemispheres.", "https://www.thespruceeats.com/thmb/hIsT74yJ0FJoa8T7wQyTl4GUHt4=/450x0/filters:no_upscale():max_bytes(150000):strip_icc()/MistikaS-ae3665f4822e490c9c9f9fbeb0ddd56b.jpg", 0.99m),
               new Fruit(6, "Raspberry", "A small, deep colored berry which has a tender texture, a sweet delicate taste and a pleasant aroma.", "https://www.thesoapkitchen.co.uk/pub/media/catalog/product/cache/a82706e56a7337702e00cd0b36547078/r/a/raspberry_seed_oil.jpg", 0.10m)
            };

            return fruit;
        }
    }
}
