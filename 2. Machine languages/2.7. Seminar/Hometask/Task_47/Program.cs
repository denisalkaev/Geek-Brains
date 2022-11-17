// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

var rnd = new Random();

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array, int minNumber, int maxNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (maxNumber - minNumber) + minNumber;
        }
    }
}

double[,] array = new double[3, 4];
FillArray(array, -10, 10);
PrintArray(array);