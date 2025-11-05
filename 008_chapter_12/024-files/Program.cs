using System.Text;
// using System.IO;

// Запись в файл (простейший вариант)
// string data = "DZHITS_NDBT";
// File.WriteAllText("filename.txt", data);

// Запись в Excel-файл (~псевдо база данных)
// StringBuilder data1 = new StringBuilder();
// for (int i = 0; i < 50; i++)
// {
//     data1.Append($"Фамилия_{i};Имя_{i};Город_{Random.Shared.Next(1, 10)}; +7 999 123 ** **;\n");
// }

// File.WriteAllText("filename.csv", data1.ToString());

// Чтение данных из файла
// string dataRead = File.ReadAllText("filename.csv");
// // Console.WriteLine(dataRead);
// List<string> dataReadList = new(dataRead.Split("\n"));
// List<string> surnamesList = new();
// foreach (string each in dataReadList)
// {
//     Console.WriteLine(each);
//     surnamesList.Add(each.Split(";")[0]);
// }
// Console.WriteLine($"{dataReadList[29]}\n");

// foreach (string each in surnamesList)
// {
//     Console.WriteLine(each);
//     File.AppendAllText("surnames.csv", $"{each}\n");
// }

// Чтение данных из файла #2
string dataRead = File.ReadAllText("filename.csv");
List<string> dataReadList = new(dataRead.Split("\n"));
List<List<string>> dataList = new();

foreach (string each in dataReadList)
{
    dataList.Add(new(each.Split(";")));
}

foreach (List<string> eachList in dataList)
{
    foreach (string each in eachList)
    {
        Console.WriteLine(each);
        File.AppendAllText("recordsList.csv", $"{each}\n");
    }
}