Console.Clear();

// Факторил 5! = 5 * 4 * 3 * 2 * 1

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"!{i} = {Factorial(i)}");
}

//  Числа Фибоначи
// f(1) = 1
// f(2) = 2
// f(n) = f(n-1) + f(n-2)

// double Fibonachi(int n)
// {
//     if (n==1 || n==2) return 1;
//     else return Fibonachi(n-1) + Fibonachi(n-2);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonachi(i)}");
// }
