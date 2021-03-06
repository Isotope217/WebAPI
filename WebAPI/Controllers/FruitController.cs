using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;
using WebAPI.Services;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IFruitService _fruitService;

        public FruitController(IFruitService service)
        {
            _fruitService = service;
        }

        [HttpGet("GetFruit")]
        public ActionResult<List<Fruit>> GetFruit()
        {
            return _fruitService.GetFruit().ToList();
        }
    }
}
