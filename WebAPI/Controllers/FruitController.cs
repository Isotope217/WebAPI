using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        [HttpGet("GetFruit")]
        public ActionResult<List<String>> GetFruit()
        {
            IEnumerable<string> fruit = new List<string>
            {
                "Apple",
                "Pear",
                "Mango",
                "Strawberry",
            };

            return fruit.ToList();
        }
    }
}
