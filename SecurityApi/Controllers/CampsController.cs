using Microsoft.AspNetCore.Mvc;

namespace SecurityCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var camps = null;
            return Ok(camps);
        }
    }
}