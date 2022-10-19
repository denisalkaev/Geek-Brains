//Задача 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int sqr = number * number;
// Console.WriteLine($"Квадрат числа {number} равен {sqr}");

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// Console.Clear();
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int i = -N;
// while (i <= N)
// {
//     Console.Write($"{i} ");
//     i +=1;
// }

// Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int i = number % 10;
Console.WriteLine($"Последняя цифра равна {i}");