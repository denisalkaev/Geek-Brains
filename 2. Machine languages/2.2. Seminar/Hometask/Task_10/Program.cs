// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number / 100 >= 1 && number / 100 < 10)
{
    int result = (number / 10) % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число введено некорректно");
}