using Telegram.Bot;

namespace Lexi.Speach.Api.Brokers.TelegramBot
{
    public partial class TelegramBotBroker: ITelegramBotBroker
    {
        private readonly string token = @"6772848738:AAEaAXDro11TLZLN7PL6BMiez9vgquhDz5o
";
        private readonly ITelegramBotClient client;

        public TelegramBotBroker()
        {
            this.client = new TelegramBotClient(token);
        }
    }
}
