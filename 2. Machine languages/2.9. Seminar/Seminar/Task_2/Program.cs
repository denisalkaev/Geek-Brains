// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

Console.Clear();

int SumDigits(int number)
{
    if (number == 0) return 0;
    int big = number / 10;
    int small = number % 10;
    return small + SumDigits(big);
}

int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumDigits(N));