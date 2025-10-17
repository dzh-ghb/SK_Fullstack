Console.WriteLine("Введите сумму счёта:");
double billAmount;
if (!double.TryParse(Console.ReadLine(), out billAmount) || billAmount <= 0)
{
    Console.WriteLine("Ошибка ввода данных");
}
else
{
    Console.WriteLine("Введите процент чаевых:");
    double tipPercentage;
    if (!double.TryParse(Console.ReadLine(), out tipPercentage)
        || tipPercentage < 0)
    {
        Console.WriteLine("Ошибка ввода данных");
    }
    else
    {
        Console.WriteLine("Введите количество человек:");
        int numberOfPeople;
        if (!int.TryParse(Console.ReadLine(), out numberOfPeople)
            || numberOfPeople <= 0)
        {
            Console.WriteLine("Ошибка ввода данных");
        }
        else
        {

            double tipAmount = billAmount * tipPercentage / 100;
            double totalAmount = billAmount + tipAmount;
            double perPersonAmount = totalAmount / numberOfPeople;

            Console.WriteLine($"Общий счёт: {totalAmount}");
            Console.WriteLine($"Процент чаевых: {tipPercentage}%");
            Console.WriteLine($"С каждого: {perPersonAmount}");
        }
    }
}