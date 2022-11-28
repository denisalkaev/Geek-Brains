// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

string NaturalNumbers(int M, int N)
{
    if (N == M) return N.ToString();
    return $"{NaturalNumbers(M, N - 1)}, {N}";
}

int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
string result = NaturalNumbers(M, N);
Console.WriteLine(result);