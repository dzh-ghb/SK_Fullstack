int score = 0;

string question = "Что означает слово 'cat'? [кошка, собака]";
Console.WriteLine(question);
string answer = Console.ReadLine().ToLower().Trim();
if (answer == "кошка")
{
    score += 10;
    Console.WriteLine("Всё верно! 😎");
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}

question = "Что означает слово 'dog'? [кошка, собака]";
Console.WriteLine(question);
answer = Console.ReadLine();
if (answer.ToLower().Trim() == "собака")
{
    score += 10;
    Console.WriteLine("Всё верно! 😎");
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}

Console.WriteLine($"Счёт: {score}");
