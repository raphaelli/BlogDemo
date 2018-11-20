using Microsoft.AspNetCore.Mvc;

namespace BlogDemo.API.Controllers
{
    [Route("api/values")]
    public class ValueController : Controller
    {
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}