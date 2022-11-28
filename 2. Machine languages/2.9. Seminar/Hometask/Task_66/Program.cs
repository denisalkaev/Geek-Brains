// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int SumNumbers(int M, int N)
{
    if (M == N) return M;
    return M + SumNumbers(M + 1, N);
}

Console.Write("Input number 1: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Input number 2: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(M, N));