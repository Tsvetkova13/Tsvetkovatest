using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TsvetkovaTest.Models;
using TsvetkovaTest.Services;

namespace TsvetkovaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public DataInput Get()
        {
            DataService dataService = new();
            return dataService.DataInput();

        }


        [HttpPost]

        public double Post()
        {
            return 0;
        }
        [HttpPut]
        public double Put()
        {
            return 0;
        }
        [HttpDelete]
        public double Delete()
        {
            return 0;
        }
    }
}
