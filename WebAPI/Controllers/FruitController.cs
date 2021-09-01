using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public ActionResult<List<String>> GetFruit()
        {
            return _fruitService.GetFruit().ToList();
        }
    }
}
