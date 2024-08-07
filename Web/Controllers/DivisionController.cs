using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionController : ControllerBase
    {
       
        [HttpGet("Add/{a}/{b}")]
        public int Get(int a, int b)
        {
           return new Calculator().Division(a, b);
        }
    }
}
