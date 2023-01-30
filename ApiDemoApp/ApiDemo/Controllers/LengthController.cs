using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LengthController : ControllerBase
    {

        private readonly ILogger<LengthController> _logger;

        public LengthController(ILogger<LengthController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLength")]
        public IEnumerable<Length> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Length
            {
                /*Date = DateTime.Now.AddDays(index),*/
                LengthCm = Random.Shared.Next(0, 21351854),
                
        })
            .ToArray();
        }
    }
}