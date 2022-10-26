using DI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        public IHomeService Ihs { get; set; }
        public IConfiguration Config { get; set; }

        public HomeController(IHomeService ihs, IConfiguration config )
        {
            Ihs = ihs;
            Config = config;
        }
        [HttpGet]
        public string Get()
        {
            return Ihs.SaySmth();
        }

        [HttpGet]
        [Route("key")]

            public string GetKey()
            {
                return Config.GetValue<string>("TestString");
            }
    }
}