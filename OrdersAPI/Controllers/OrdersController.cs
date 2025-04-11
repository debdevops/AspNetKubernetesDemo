using Microsoft.AspNetCore.Mvc;

namespace OrdersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "Order1", "Order2", "Order3" };
        }
    }
}