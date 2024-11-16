using Microsoft.AspNetCore.Mvc;

namespace WhereHaveYouBeen.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MappingController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<MappingController> _logger;

        public MappingController(ILogger<MappingController> logger)
        {
            _logger = logger;
        }


    }
}