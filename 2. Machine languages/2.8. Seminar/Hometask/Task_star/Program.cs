// Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, 
// которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.

Console.Clear();

int MySqrt(int number)
{
    int i = 1;
    while (number >= i * i) i++;
    return i-1;
}

Console.Write("Input number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Integer of square root = {MySqrt(N)}");