// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.Clear();

void FirTree(int value)
{
    int size = value;
    int count = 1;
    for (int i = 0; i < value; i++)
    {
        string[] array = new string[size];
        for (int j = 0; j < size - count; j++)
        {
            array[j] = " ";
        }
        for (int k = size - count; k < size; k++)
        {
            array[k] = "*";
        }
        Console.WriteLine(string.Join("", array));
        size += 1;
        count += 2;
    }
}

Console.Write("Input value: ");
int N = int.Parse(Console.ReadLine()!);
FirTree(N);