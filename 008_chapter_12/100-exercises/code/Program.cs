string input = Console.ReadLine();

HashSet<char> uniqueChars = new();
foreach (char c in input) uniqueChars.Add(c);
Console.WriteLine(String.Join("", uniqueChars));
Dictionary<char, int> res = new(uniqueChars.Count);
foreach (char c in uniqueChars)
{
    res.Add(c, 0);
}
Console.WriteLine(String.Join("", res));

for (int i = 0; i < input.Length; i++)
{
    foreach (var key in res.Keys)
    {
        if (key == input[i]) res[key]++;
    }
}
Console.WriteLine(String.Join("", res));