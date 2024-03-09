// Сформировать из строки массив символов и вывести его на экран

char[] GetCharsFromString(string str)
{
    char[] charsArray = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        charsArray[i] = str[i];
    }
    return charsArray;
}

void PrintArray(char[] array)
{
    foreach (char item in array)
    {
        Console.Write($"{item} ");
    }
}

string str = "Hello";
char[] array = GetCharsFromString(str);
PrintArray(array);