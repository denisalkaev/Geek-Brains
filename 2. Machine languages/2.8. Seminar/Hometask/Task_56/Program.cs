// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

var rnd = new Random();

void PrintArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array2D, int minNumber, int maxNumber)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
}

void FindMaxSumInRows(int[,] array2D)
{
    int rowNumber = 0;
    int sumRow = 999999999;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        if (sum < sumRow) { rowNumber = i; sumRow = sum; }
    }
    Console.WriteLine($"Minimal sum in the {rowNumber + 1} row");
}


int[,] myArray = new int[3, 3];
FillArray(myArray, 1, 10);
PrintArray(myArray);
Console.WriteLine();
FindMaxSumInRows(myArray);