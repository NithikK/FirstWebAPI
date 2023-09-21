using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FirstWebApiLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //api/Calculator/Add?x=10&y=10
        [HttpGet("/api/Calculator/Add")]
        public int Add(int x, int y)
        {
            return x + y;
        }
        //api/Calculator/Substract?x=10&y=10
        [HttpGet("/api/Substract")]
        public int Substract(int x, int y)
        {
            return x - y;
        }
        //api/Calculator/Multiply?x=10&y=10
        [HttpGet("/api/Multiply")]//to have multiply get give parameters
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        //api/Calculator/Divide?x=10&y=10
        [HttpGet("/api/Divide")]
        public double Divide(int x, int y)
        {
            return x / y;
        }
        //api/Calculator/Power?x=10&y=10
        [HttpGet("/api/Power")]
        public double Power(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }
}
