//  Являются ли введеные числа сторонами треугольника

Console.Clear();

bool CheckTriangle(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Triangle with sides {a} {b} {c} " + (CheckTriangle(a, b, a) ? "is" : "is not") + " triangle");