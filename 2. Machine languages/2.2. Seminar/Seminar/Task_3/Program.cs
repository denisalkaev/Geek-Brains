// Кратно ли число 7 и 23
Console.Clear();
Console.WriteLine("Ввидетие число");
int number = int.Parse(Console.ReadLine()!);

string answer;
if (number % 7 == 0 && number % 23 == 0)
{
    answer = "Число {number} кратно 7 и 23";
}
else
{
    answer = "Число {number} не кратно 7 и 23";
}

Console.WriteLine(answer);