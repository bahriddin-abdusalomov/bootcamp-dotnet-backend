using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Polling;

namespace Agenda.Services
{
    public class UpdateHandlerService : IUpdateHandler
    {
        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
