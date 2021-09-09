using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class FruitService : IFruitService
    {
        private readonly IRepository<Fruit> _fruitRepo;

        public FruitService(IRepository<Fruit> repo)
        {
            _fruitRepo = repo;
        }

        public IEnumerable<Fruit> GetFruit()
        {
            return _fruitRepo.Get();
        }
    }
}
