using System.Collections.Generic;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public interface IFruitService
    {
        IEnumerable<Fruit> GetFruit();
    }
}
