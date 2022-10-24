using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;

namespace Main.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ITelegramBotClient _telegramBotClient;
    
    public WeatherForecastController(ITelegramBotClient telegramBotClient)
    {
        _telegramBotClient = telegramBotClient;
    }

    [HttpPost]
    public ActionResult<string> Okay()
    {
        return Request.Body.ToString();
    }
    
    [HttpGet]
    public ActionResult<string> Sasa()
    {
        return "А я нет";
    }
    
    [HttpGet]
    public ActionResult<string> Das()
    {
        return "Не надо ДЯДЯ НЕ НААДДАДАДАДАДАД";
    }
}