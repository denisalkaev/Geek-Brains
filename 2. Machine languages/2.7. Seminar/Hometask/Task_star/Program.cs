// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

var dict = new Dictionary<char, int>()
{
    {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
};

int RomanToArabian(string text)
{
    int res = 0;
    int curr = 0;
    int prev = 0;
    for (int i = text.Length - 1; i >= 0; i--)
    {
        curr = dict[text[i]];
        if (curr >= prev) res += curr;
        else if (curr == 1 || curr == 10 || curr == 100 || curr == 1000) res -= curr;
        prev = curr;
    }
    return res;
}

Console.Write("Input roman number: ");
string N = Console.ReadLine()!;
Console.WriteLine($"Arabian number is {RomanToArabian(N)}");