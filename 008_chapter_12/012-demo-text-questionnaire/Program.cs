int score = 0;

string question = "Что означает слово 'cat'? [кошка, собака]";
Console.WriteLine(question);
string answer = Console.ReadLine();
if (answer == "кошка" || answer == "кот" || answer == "киса" || answer == "котя")
{
    score += 10;
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

question = "\nЧто означает слово 'dog'? [кошка, собака]";
Console.WriteLine(question);
answer = Console.ReadLine();
if (answer == "собака" || answer == "песель" || answer == "песик" || answer == "пес")
{
    score += 10;
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

Console.WriteLine($"\nСчет: {score}");

// int score = 0;

// string question = "Что означает слово 'cat'? [кошка, собака]";
// Console.WriteLine(question);
// string answer = Console.ReadLine();
// if (answer == "кошка")
// {
//     score += 10;
//     Console.WriteLine("Всё верно! 😎");
// }
// else
// {
//     Console.WriteLine("Нужно подумать ещё 🫣");
// }

// question = "Что означает слово 'dog'? [кошка, собака]";
// Console.WriteLine(question);
// answer = Console.ReadLine();
// if (answer == "собака")
// {
//     score += 10;
//     Console.WriteLine("Всё верно! 😎");
// }
// else
// {
//     Console.WriteLine("Нужно подумать ещё 🫣");
// }

// Console.WriteLine($"Счёт: {score}");
