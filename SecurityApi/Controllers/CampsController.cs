using Microsoft.AspNetCore.Mvc;
using MyCodeCamp.Data;

namespace SecurityCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : Controller
    {
        private ICampRepository campRepository { get; set; }
        public CampsController (ICampRepository _campRepository)
        {
            campRepository = _campRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}