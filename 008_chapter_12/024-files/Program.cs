// using System.IO;

// string data = "";

// for (int i = 0; i < 1000; i++)
// {
//     data += $"Имя_{i};Фамилия_{i};Город_{Random.Shared.Next(1, 10)}; +7 999 123 ** **;\n";
// }

// File.WriteAllText("filename.csv", data);


// string[] dataRead = File.ReadAllText("filename.csv")
//                         .Split('\n');

// string[] personInfo = dataRead[0].Split(';');
// foreach (var item in personInfo)
// {
//     Console.WriteLine(item);
// };
// Console.WriteLine(dataRead[0]);


// string[] dataRead = File.ReadAllText("filename.csv")
//                         .Split('\n');

// for (int i = 0; i < dataRead.Length; i++)
// {
//     string[] personInfo = dataRead[i].Split(';');
//     // Console.WriteLine(personInfo[0]);
//     File.AppendAllText("names.csv", personInfo[0] + '\n');
// }

// Environment.NewLine // \n 
// \n\r
























return;
// Создание и запись в файл
string filePath = "example.txt";
File.WriteAllText(filePath, "Привет, мир!");
Console.WriteLine("Файл создан и в него записан текст.");

// Чтение из файла
string content = File.ReadAllText(filePath);
Console.WriteLine("Содержимое файла:");
Console.WriteLine(content);

// Построчная запись и чтение с использованием StreamWriter и StreamReader
using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine("Строка 1");
    writer.WriteLine("Строка 2");
}
Console.WriteLine("В файл дописаны строки.");

using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    Console.WriteLine("Чтение файла построчно:");
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Работа с путями
string fullPath = Path.Combine(Environment.CurrentDirectory, filePath);
Console.WriteLine($"Полный путь к файлу: {fullPath}");
Console.WriteLine($"Расширение файла: {Path.GetExtension(fullPath)}");

// Создание каталога и перемещение файла в него
string directoryPath = Path.Combine(Environment.CurrentDirectory, "TestDirectory");
Directory.CreateDirectory(directoryPath);
Console.WriteLine("Каталог создан.");

string movedFilePath = Path.Combine(directoryPath, filePath);
if (!File.Exists(movedFilePath))
{
    File.Move(filePath, movedFilePath);
    Console.WriteLine("Файл перемещен в новый каталог.");
}