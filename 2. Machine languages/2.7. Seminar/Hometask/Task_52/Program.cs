// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void AverageArray(int[,] array)
{
    double[] res = new double[array.GetLength(1)];
    for (int col = 0; col < array.GetLength(1); col++)
    {
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum += array[row, col];
        }
        res[col] = sum / Convert.ToDouble(array.GetLength(0));
    }
    Console.WriteLine(string.Join(", ", res));
}

int[,] array = new int[4, 3];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
AverageArray(array);