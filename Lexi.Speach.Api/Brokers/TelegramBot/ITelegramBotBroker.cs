using Telegram.Bot.Types;
using Telegram.Bot;

namespace Lexi.Speach.Api.Brokers.TelegramBot
{
    public interface ITelegramBotBroker
    {
        void StartTelegramBot(
            Func<ITelegramBotClient, Update, CancellationToken, Task> handleUpdate,
            Func<ITelegramBotClient, Exception, CancellationToken, Task> handleError
            );
    }
}
