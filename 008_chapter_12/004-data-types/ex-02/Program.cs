namespace ReferenceType
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Пример работы с классами
            Person person = new Person { Name = "Алексей", Age = 30 };
            Console.WriteLine("Человек: Имя - " + person.Name + ", Возраст - " + person.Age);
            IGreet greeter = new Greeter();
            greeter.SayHello();

            // Пример работы с массивами
            int[] numbersArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Массив чисел: " + string.Join(", ", numbersArray));
            DisplayMessage displayMessage = message => Console.WriteLine(message);
            displayMessage("Сообщение через делегат");
            PersonRecord personRecord = new PersonRecord("Мария", 28);
            Console.WriteLine("Record: Имя - " + personRecord.Name + ", Возраст - " + personRecord.Age);
        }
    }

    // Пример работы с интерфейсами
    interface IGreet
    {
        void SayHello();
    }

    class Greeter : IGreet
    {
        public void SayHello() => Console.WriteLine("Привет!");
    }

    // Пример работы с делегатами
    delegate void DisplayMessage(string message);

    // Пример работы с record
    record PersonRecord(string Name, int Age);

    // Пример работы с классами
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}