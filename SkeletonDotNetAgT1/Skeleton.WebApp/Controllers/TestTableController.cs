using Microsoft.AspNetCore.Mvc;
using Skeleton.BL;

namespace Skeleton.WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestTableController : ControllerBase
    {
        [HttpGet("testcall")]
        public ActionResult TestCall()
        {
            return Ok("Test call got it's response. I am that response.");
        }

        [HttpGet("get")]
        public ActionResult Get()
        {
            var repo = new TestTableRepository();
            return Ok(repo.Get());
        }
    }
}
