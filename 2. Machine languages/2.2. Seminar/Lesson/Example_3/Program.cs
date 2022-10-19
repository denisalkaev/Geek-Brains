// Найти элемент из массива

int[] array = { 23, 45, 67, 23, 23, 4, 34, 4, 6, 34 };

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерывает программу
    }
    index++;
}
