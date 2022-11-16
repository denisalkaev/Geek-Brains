// Задача со звездочкой: Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.

Console.Clear();

void PrintArray(int[,] array)
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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] array = new int[3, 3];
int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];

FillArray(array);
Console.WriteLine("Your array is:");
PrintArray(array);

void FlattenArray(int row, int col)
{
    int N = array[row, col];
    Console.WriteLine(N);

    if (row < array.GetLength(0) && row >= 0 && col < array.GetLength(1) && col >= 0)
    {
        FlattenArray(row, col + 1);
        FlattenArray(row - 1, col);
        FlattenArray(row, col - 1);
        FlattenArray(row + 1, col);
    }
}

FlattenArray(2, 0);
