/*Напишите программу, которая будет выдавать 
название дня недели по заданному номеру*/
Console.Clear();
Console.Write("Введите номер дня недели: ");
String userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);
if (a == 1)
{
    Console.WriteLine($"a = {a} -> Понедельник");
}
if (a == 2)
{
    Console.WriteLine($"a = {a} -> Вторник");
}
if (a == 3)
{
    Console.WriteLine($"a = {a} -> Среда");
}
if (a == 4)
{
    Console.WriteLine($"a = {a} -> Четверг");
}
if (a == 5)
{
    Console.WriteLine($"a = {a} -> Пятница");
}
if (a == 6)
{
    Console.WriteLine($"a = {a} -> Суббота");
}
if (a == 7)
{
    Console.WriteLine($"a = {a} -> Воскресенье");
}