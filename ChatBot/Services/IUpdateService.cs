using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace ChatBot.Services
{
    public interface IUpdateService
    {
        Task EchoAsync(Update update);
    }
}
