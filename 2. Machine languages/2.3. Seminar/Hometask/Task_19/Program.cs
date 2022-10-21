// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

string Palindrome(int num)
{
    string answer;
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
    {
        answer = $"Число {num} - палнидром";
    }
    else
    {
        answer = $"Число {num} - обычное число";
    }
    return answer;
}

Console.Clear();
Console.Write("Введите пятизначное целое число: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write(Palindrome(X));
