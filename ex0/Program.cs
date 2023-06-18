Console.Clear();
Console.Write("Введите целое число: ");
String userInput = Console.ReadLine() ?? ""; 
int UserNumber = int.Parse(userInput);

int result = UserNumber*UserNumber;

Console.WriteLine($"{UserNumber} -> {result}");