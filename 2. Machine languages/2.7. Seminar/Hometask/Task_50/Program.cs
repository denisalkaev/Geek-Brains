// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.

Console.Clear();

var rnd = new Random();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array, int minNumber, int maxNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
}

void FindNumber(int[,] array, int N)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N)
            {
                Console.WriteLine($"Number {N} is in array, row = {i + 1}, column = {j + 1}");
                return;
            }
        }
    }
    Console.WriteLine($"Number {N} is not in array");
}

int[,] array = new int[4, 4];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);
FindNumber(array, num);