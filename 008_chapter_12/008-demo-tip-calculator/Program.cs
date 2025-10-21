Console.Write("Введите сумму счета: ");
double billAmount = double.Parse(Console.ReadLine());
Console.Write("Введите процент чаевых: ");
double tipPercentage = double.Parse(Console.ReadLine());
Console.Write("Введите количество людей: ");
int numberOfPeople = int.Parse(Console.ReadLine());

double tipAmount = billAmount * tipPercentage * 0.01;
double totalAmount = billAmount + tipAmount;
double perPersonAmount = totalAmount / numberOfPeople;

Console.WriteLine($"Общий счет: {Math.Round(totalAmount, 2)}");
Console.WriteLine($"Процент чаевых: {tipPercentage}%");
Console.WriteLine($"Сумма на каждого: {Math.Round(perPersonAmount, 2)}");

// Console.Write("Введите сумму счёта: ");
// double billAmount = double.Parse(Console.ReadLine());

// Console.Write("Введите процент чаевых: ");
// double tipPercentage = double.Parse(Console.ReadLine());

// Console.Write("Введите количество человек: ");
// int numberOfPeople = int.Parse(Console.ReadLine());

// double tipAmount = billAmount * tipPercentage / 100;
// double totalAmount = billAmount + tipAmount;
// double perPersonAmount = totalAmount / numberOfPeople;

// Console.WriteLine($"Общий счёт: {totalAmount}");
// Console.WriteLine($"Процент чаевых: {tipPercentage}%");
// Console.WriteLine($"С каждого: {perPersonAmount}");