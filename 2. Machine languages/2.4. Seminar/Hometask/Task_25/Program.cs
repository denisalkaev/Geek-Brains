// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

void GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Input value: ");
        int N = int.Parse(Console.ReadLine()!);
        array[i] = N;
    }
}

double MyPow(int[] array)
{
    double Mult = 1;
    for (int i = 1; i <= array[1]; i++)
    {
        Mult *= array[0];
    }
    return Mult;
}


int[] newArray = new int[2];
GetArray(newArray);
Console.WriteLine(MyPow(newArray));