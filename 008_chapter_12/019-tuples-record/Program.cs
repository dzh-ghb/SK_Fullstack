// (int x, int y, string name, int[] values) pair = (1, 2, "str", new[] { 1, 2, 3 });
//// var pair = (1, 2, "str", new[] { 1, 2, 3 });
// Console.WriteLine(pair.Item1);
// Console.WriteLine(pair.x);
// Console.WriteLine(pair.y);
// Console.WriteLine(pair.name);
// Console.WriteLine(String.Join(", ", pair.Item4));
// Console.WriteLine(String.Join(", ", pair.values));

// var (x, y, name, values) = pair;
// Console.WriteLine(x);
// return;

// Использование кортежей
var myTuple = (1, "hello", true);
// Console.WriteLine(myTuple);
Console.WriteLine($"Кортеж - число: {myTuple.Item1}, строка: {myTuple.Item2}, булево: {myTuple.Item3}");

// Деконструкция кортежа
var (number, word, flag) = myTuple;
Console.WriteLine($"Деконструкция - число: {number}, строка: {word}, булево: {flag}");

// Использование именованных кортежей
var namedTuple = (Count: 1, Greeting: "hello", Flag: true);
Console.WriteLine($"Именованный кортеж - Count: {namedTuple.Count}, Greeting: {namedTuple.Greeting}");



// Использование record
var person1 = new Person("John", "Doe");
Console.WriteLine(person1.FirstName);
Console.WriteLine(person1.LastName);
var person2 = new Person("John", "Doe");
// True
Console.WriteLine($"Record сравнение - равны ли person1 и person2: {person1 == person2}");

// Клонирование и модификация record
var person3 = person1 with { LastName = "Smith" };
Console.WriteLine($"Клонирование и модификация record - новая фамилия: {person3.LastName}");

// Определение record
public record Person(string FirstName, string LastName);
