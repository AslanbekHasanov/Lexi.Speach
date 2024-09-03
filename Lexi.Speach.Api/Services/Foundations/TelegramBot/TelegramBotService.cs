using Lexi.Speach.Api.Brokers.TelegramBot;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Lexi.Speach.Api.Services.Foundations.TelegramBot
{
    public class TelegramBotService: ITelegramBotService
    {
        private readonly ITelegramBotBroker botBroker;

        private static readonly string azureSubscriptionKey = "YOUR_AZURE_SUBSCRIPTION_KEY";
        private static readonly string azureRegion = "YOUR_AZURE_REGION";

        public TelegramBotService() 
        {
            this.botBroker = new TelegramBotBroker();
        }

        public void StartBot()
        {
            this.botBroker.StartTelegramBot(HandleUpdate, HandleError);
        }

        private async Task HandleUpdate(ITelegramBotClient client, Update update, CancellationToken token)
        {

            try
            {
                if(update.Message?.Type is MessageType.Voice)
                {
                    //var config = SpeechConfig.FromSubscription("8a94c3b6bbb8484aa4383ad659fb805f", "eastasia");

                    //using (var recognizer = new SpeechRecognizer(config))
                    //{
                    //    Console.WriteLine("Say something...");

                    //    var result = await recognizer.RecognizeOnceAsync();

                    //    if (result.Reason == ResultReason.RecognizedSpeech)
                    //    {
                    //        Console.WriteLine($"Recognized: {result.Text}");
                    //    }
                    //    else if (result.Reason == ResultReason.NoMatch)
                    //    {
                    //        Console.WriteLine("No speech could be recognized.");
                    //    }
                    //    else if (result.Reason == ResultReason.Canceled)
                    //    {
                    //        var cancellation = CancellationDetails.FromResult(result);
                    //        Console.WriteLine($"Canceled: {cancellation.Reason}");
                    //        Console.WriteLine($"ErrorDetails: {cancellation.ErrorDetails}");
                    //    }
                    //}

                }

            }
            catch (Exception ex)
            {
                await client.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: $"Error!\n{ex.Message}");
            }
        }
     
    private async Task HandleError(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            await client.SendTextMessageAsync(
                chatId: 6772848738,
                text: "Error!");
        }
    }
}
