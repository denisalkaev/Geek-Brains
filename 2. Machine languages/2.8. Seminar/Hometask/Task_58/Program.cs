// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultArray(int[,] array1, int[,] array2)
{
    int[,] array2D = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            int value = 0;
            for (int k = 0; k < array2D.GetLength(0); k++)
            {
                value += array1[i, k] * array2[k, j];
            }
            array2D[i, j] = value;
        }
    }
    return array2D;
}


int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
FillArray(array1, 0, 3);
FillArray(array2, 0, 3);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

PrintArray(MultArray(array1, array2));