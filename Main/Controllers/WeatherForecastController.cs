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

    [HttpGet]
    public ActionResult<string> Okay()
    {
        return "Ты гуль ахахахах вфвфы";
    }
    
    [HttpGet]
    public ActionResult<string> Sasa()
    {
        return "А я нет";
    }
    
    [HttpGet]
    public ActionResult<string> Das()
    {
        return "Не надо ДЯДЯ";
    }
}