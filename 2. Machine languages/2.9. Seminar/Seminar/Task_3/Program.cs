// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.Clear();

double SquareNum(int value, int x)
{
    if (x == 0) return 1;
    return SquareNum(value, x - 1) * value;
}

int N = int.Parse(Console.ReadLine()!);
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine(SquareNum(N, X));