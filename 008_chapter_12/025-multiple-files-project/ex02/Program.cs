using MyApp.Services;

PersonService personService = new PersonService();
var person = personService.CreatePerson("Иван", 30);
Console.WriteLine($"Создан человек: {person.Name}, возраст {person.Age}");
