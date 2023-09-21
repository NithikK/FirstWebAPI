using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPILink.Controllers
{
    [ApiController]
    public class DemoController : ControllerBase
    {
        //api/Calculator/Add?x=100&y=20
        [HttpGet("api/Demo/Add")]
        public int Add(int x, int y)
        {
            return x + y + 1000;
        }
    }
}
