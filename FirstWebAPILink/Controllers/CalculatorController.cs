using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPILink.Controllers
{
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //api/Calculator/Add?x=100&y=20
        [HttpGet("api/Calculator/Add")]
        public int Add(int x, int y)
        {
            return x + y;
        }
        //api/Calculator/Subtract?x=100&y=20
        [HttpGet("api/Calculator/Substract")]
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        //api/Calculator/Multiply?x=100&y=20
        [HttpGet("api/Calculator/Multiply")]
        public int Multiply(int x, int y)
        {
            return x*y;
        }
        //api/Calculator/Divide?x=100&y=20
        [HttpGet("api/Calculator/Divide")]
        public double Divide(int x, int y)
        {
            return x/y;
        }
        //api/Calculator/Power?x=2&y=3
        [HttpGet("api/Calculator/Power")]
        public double Power(int x, int y)
        {
            return Math.Pow(x, y);
        }

    }
}
