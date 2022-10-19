// Нахождение максимума
Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 11;
int a2 = 11;
int a3 = 11;
int b1 = 11;
int b2 = 11;
int b3 = 11;
int c1 = 11;
int c2 = 11;
int c3 = 11;


int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);