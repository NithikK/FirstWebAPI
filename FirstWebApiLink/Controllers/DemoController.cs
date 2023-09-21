using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        //api/Calculator/Add?x=10&y=10
        [HttpGet("/api/Demo/Add")]
        public int Add(int x, int y)
        {
            return x + y +50000;
        }
    }
}
