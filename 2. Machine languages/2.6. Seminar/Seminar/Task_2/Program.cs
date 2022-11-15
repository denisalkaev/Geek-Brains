// Перевести десятичное число в двоичное

Console.Clear();

int GetBinarNumber(int number)
{
    string result = String.Empty;
    if (number == 0) return 0;
    while (number > 0)
    {
        result += (number % 2).ToString();
        number /= 2;
    }
    return int.Parse(result); //  Необходимо перевести в число полученное значение, чтобы можно было осуществлять с ним действия
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetBinarNumber(num));