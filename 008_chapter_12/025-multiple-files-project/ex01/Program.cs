using static Methods;

// int[] ints = CreateArray(12);
int[] ints = FillArray1(12);
// PrintBad(ints);
string output = Join(ints);
// Console.WriteLine(output);
File.WriteAllText("output_ints.txt", output);
int[] evenNumbers = FindEven(ints);
// PrintBad(evenNumbers);
output = Join(evenNumbers);
// Console.WriteLine(output);
File.WriteAllText("output_evenNumbers.txt", output);