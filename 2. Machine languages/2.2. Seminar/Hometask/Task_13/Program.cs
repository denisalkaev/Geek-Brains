// Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number / 100 >= 1)
{
    int result = (number / 100) % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}