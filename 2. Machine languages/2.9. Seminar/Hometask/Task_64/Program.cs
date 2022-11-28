// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

string ShowNumbers(int value)
{
    if (value == 1) return value.ToString();
    return $"{value}, {ShowNumbers(value - 1)}";
}

Console.Write("Input number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(ShowNumbers(N));