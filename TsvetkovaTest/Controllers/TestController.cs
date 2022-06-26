using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TsvetkovaTest.Models;
using TsvetkovaTest.Services;
using System.Threading.Tasks;

namespace TsvetkovaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// GET-запрос 
        /// </summary>
        /// <returns>Данные работников</returns>
        [HttpGet]
        public  async Task Get()
        {
            /*var app = builder.Build();

            app.Run(async context =>
            {
                var timeService = app.Services.GetService<IEmployeeService>();
                await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
            });

            app.Run();*/
            /*DataService dataService = new();
            return dataService.DataInput();*/

        }

        /// <summary>
        /// PUT-запрос. Добавление нового работника в коллекцию
        /// </summary>
        /// <returns>Данные работников</returns>


        [HttpPut]
        public async Task Put()
        {
            /*DataService dataService = new();
            return dataService.DataInput();*/
        }

        /// <summary>
        /// DELTE-запрос. Удаление работника из коллекцию
        /// </summary>
        /// <returns>Данные работников</returns>
        [HttpDelete]
        public async Task Delete()
        {
            /*DataService dataService = new();
            return dataService.DataInput();*/
        }
    }
}
