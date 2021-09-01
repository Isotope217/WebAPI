using System;
using System.Collections.Generic;

namespace WebAPI.Services
{
    public class FruitService : IFruitService
    {
        public IEnumerable<String> GetFruit()
        {
            IEnumerable<string> fruit = new List<string>
            {
                "Apple",
                "Pear",
                "Mango",
                "Strawberry",
            };

            return fruit;
        }
    }
}
