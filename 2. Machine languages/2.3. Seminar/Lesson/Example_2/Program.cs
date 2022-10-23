// В тексте нужно заменить маленькте буквы "к" большими "К",
// а большие "С" заменить маленькими "с"

string text = "Конек-горбунок " + "Стрекоза";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += newValue;
        else result += text[i];
    }
    return result;
}

Console.WriteLine(Replace(text, 'К', 'к'));