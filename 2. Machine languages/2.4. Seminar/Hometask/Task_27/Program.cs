// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int SumNumbers(int value)
{
    int sum = 0;
    while (value != 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

Console.Write("Input value: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of numbers = {SumNumbers(N)}");