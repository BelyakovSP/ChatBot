using Telegram.Bot;

namespace ChatBot.Services
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}