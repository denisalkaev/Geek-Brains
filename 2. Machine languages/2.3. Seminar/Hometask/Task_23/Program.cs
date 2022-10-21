// Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

double[] numberPower(int number, int power)
{
    double[] array = new double[number];
    int index = 0;
    while (index + 1 <= number)
    {
        array[index] = Math.Pow(index + 1, power);
        index++;
    }
    return array;
}

Console.Clear();
int num = int.Parse(Console.ReadLine()!);
var str = string.Join(", ", numberPower(num, 3));
Console.WriteLine($"Результат числа {num} -> {str}");