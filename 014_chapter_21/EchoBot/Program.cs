using Telegram.Bot;

if (args.Length != 1)
{
    Console.WriteLine("Specify the token in the argument");
    return;
}
string token = args[0];

var client = new TelegramBotClient(token);

string GetAnswer(string msg)
{
    string answer = "Position number one - DZHITS\nPosition number two - _NDBT";
    if (msg.ToLower().Contains("dzhits"))
    {
        answer = "_ndbt";
    }
    return answer;
}

// метод обработки получения сообщений
// параметр "c" содержит функционал для работы с отправкой сообщений (разных типов)
// параметр "arg" содержит функционал для работы с полученными сообщениями
client.StartReceiving(
    (c, arg, _) =>
    {
        Console.WriteLine($"{DateTime.Now}: {arg.Message!.Chat.FirstName} (text: {arg.Message!.Text})");
        // Чтобы показать ник -> Console.WriteLine(arg.Message.Chat.Username)
        return c.SendMessage(
            chatId: arg.Message!.Chat.Id,
            text: GetAnswer(arg.Message.Text!.ToLower())
        );
    }, (_, _, _) => Task.CompletedTask
);

Console.WriteLine("StartReceiving...");

await Task.Delay(-1); // "бесконечный цикл", чтобы приложение не закрывалось после запуска;
                      // вместо Console.ReadLine(); (в Docker мб траблы из-за этого)