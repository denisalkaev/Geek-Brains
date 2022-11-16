// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Input {j + 1} value for {i + 1} line: ");
            array[i, j] = double.Parse(Console.ReadLine()!);
        }
    }
}

double[] GetСoordinates(double[,] array)
{
    double[] res = new double[2];
    double x = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
    Console.WriteLine($"({array[1, 1]} - {array[0, 1]}) / ({array[0, 0]} - {array[1, 0]})");
    double y = array[0, 0] * x + array[0, 1];
    res[0] = x;
    res[1] = y;

    return res;
}

double[,] array = new double[2, 2];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine($"Coordinates of line's intersection: ({string.Join("; ", GetСoordinates(array))})");