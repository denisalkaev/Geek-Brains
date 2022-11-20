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

void FlattenArray(int[,] array)
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    int[] result = new int[height * width];
    int col = 0, index = 0, delta = 1;

    for (int row = height - 1; row >= 0; row--)
    {// перебор строк
        while (col >= 0 && col < width)
        {
            result[index] = array[row, col];
            col += delta;
            index++;
        }
        if (delta > 0 && col == width)
        {// разворот обхода строки <<<<<
            col -= 1;
            delta = -1;
            continue;
        }
        if (delta < 0 && col < 0)
        {// разворот обхода строки >>>>>
            col = 0;
            delta = 1;
            continue;
        }
    }
    Console.WriteLine("Your NEW array is:");
    Console.WriteLine(string.Join(", ", result));
}

int[,] array = new int[3, 3];
FillArray(array);
Console.WriteLine("Your array is:");
PrintArray(array);
Console.WriteLine();
FlattenArray(array);
