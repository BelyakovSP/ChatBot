using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatBot.Services;
using Telegram.Bot.Types;

namespace ChatBot.Controllers
{
    [Route("api/[controller]")]
    public class UpdateController : Controller
    {
        private readonly IUpdateService _updateService;

        public UpdateController(IUpdateService updateService)
        {
            _updateService = updateService; // сервис - обработчик сообщений из Телеграмм
        }

        // POST api/update
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update update) // update - это то, что пришло из Телеграмм
        {
            await _updateService.EchoAsync(update);
            return Ok();
        }
    }
}
