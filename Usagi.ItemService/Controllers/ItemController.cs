using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace usagi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "House", "Hi-Fi", "Car", "Bracelett", "PC", "Phone"
        };

        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TheItem> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TheItem
            {                
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
