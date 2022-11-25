// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

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

int[] FlattenArray(int[,] array2D)
{
    int sizeRow = array2D.GetLength(0);
    int sizeCol = array2D.GetLength(1);
    int deletedRow = 0;
    int deletedCol = 0;
    int row = 0;
    int col = 0;
    int counter = sizeRow * sizeCol;
    var arra1D = Array.Empty<int>();

    while (counter > 0)
    {
        for (int j = col; j < sizeCol; j++)
        {
            // Console.Write($"{array2D[row, j]} \t");
            arra1D = arra1D.Append(array2D[row, j]).ToArray();
            col = j;
            counter--;
        }
        row++;

        for (int i = row; i < sizeRow; i++)
        {
            // Console.Write($"{array2D[i, col]} \t");
            arra1D = arra1D.Append(array2D[i, col]).ToArray();
            row = i;
            counter--;
        }
        col--;
        sizeRow--;
        sizeCol--;

        for (int k = col; k >= deletedCol; k--)
        {
            // Console.Write($"{array2D[row, k]} \t");
            arra1D = arra1D.Append(array2D[row, k]).ToArray();
            col = k;
            counter--;
        }
        row--;
        deletedCol++;

        for (int l = row; l > deletedRow; l--)
        {
            // Console.Write($"{array2D[l, col]} \t");
            arra1D = arra1D.Append(array2D[l, col]).ToArray();
            row = l;
            counter--;
        }
        col++;
        deletedRow++;
    }
    return arra1D;
}

int[,] ConvertTo2D(int[] array1D)
{
    int index = 0;
    int size = Convert.ToInt32(System.Math.Sqrt(array1D.Length));
    int[,] array2d = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            array2d[i, j] = array1D[index];
            index++;
        }
    }
    return array2d;
}

int[,] myArray = new int[3, 3];
FillArray(myArray, 1, 100);
PrintArray(myArray);
Console.WriteLine();

int[] array1D = FlattenArray(myArray);
int[,] array2D = ConvertTo2D(array1D);
PrintArray(array2D);