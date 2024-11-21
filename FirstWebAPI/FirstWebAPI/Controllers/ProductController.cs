using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]         // [Route("api/[controller]")]  =========>THIS WILL ALLOW ONLY ONE GET AT A RUN . INORDER TO GET ALL THE GET METHOD USE [ACTION]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Guys!!!";
        }


        [HttpGet]
        public string GetProduct()
        {
            return "Hello Frnds";
        }

    }
}
