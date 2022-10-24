using Telegram.Bot;

namespace Main.Extensions.DependencyInjection;

public static class TelegramBotServiceCollectionExtensions
{
    public static IServiceCollection AddTelegramBot(this IServiceCollection services, string token)
    {
        services.AddTransient<ITelegramBotClient, TelegramBotClient>(serviceProvider => new TelegramBotClient(token));
        
        return services;
    }
}