using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Main.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TelegramController : ControllerBase
{
    private readonly ITelegramBotClient _telegramBotClient;

    public TelegramController(ITelegramBotClient telegramBotClient)
    {
        _telegramBotClient = telegramBotClient;
    }
    
    [HttpPost]
    public async Task<IActionResult> Update([FromBody] Update update)
    {
        if (update.Type == UpdateType.Message)
        {
            await _telegramBotClient.SendTextMessageAsync(update.Message.From.Id, "answer");
        }

        return Ok();
    }
} // TelegramController.
