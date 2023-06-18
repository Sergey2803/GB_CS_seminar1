/*Напишите программу которая на вход принимает два целых числа, 
и проверяет является ли первое число квадратом второго.
*/
Console.Clear();

Console.Write("Введите первое целое число: ");
String userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
String userInput2 = Console.ReadLine() ?? ""; 
int b = int.Parse(userInput2);

if (a == b*b)
{
    Console.WriteLine($"a = {a}, b = {b}, -> да");
}
else
{
    Console.WriteLine($"a = {a}, b = {b}, -> нет");
}