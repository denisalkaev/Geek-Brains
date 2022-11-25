// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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

void SortedArray(int[,] array2D)
{
    int curr = 0;
    int prev = 0;

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int k = 1; k < array2D.GetLength(1); k++)
        {
            for (int j = 1; j < array2D.GetLength(1); j++)
            {
                curr = array2D[i, j];
                prev = array2D[i, j - 1];
                if (curr > prev) { array2D[i, j - 1] = curr; array2D[i, j] = prev; }
            }
        }
    }
}

int[,] myArray = new int[4, 4];
FillArray(myArray, 1, 10);
PrintArray(myArray);
Console.WriteLine();
SortedArray(myArray);
PrintArray(myArray);