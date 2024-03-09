// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных.

int CountVowels(string str)
{
    int count = 0;
    string vowels = "aeiouy";
    foreach (char item in str.ToLower())
    {
        if (vowels.Contains(item))
        {
            count++;
        }
    }
    return count;
}

string str = "Test string";
int count = CountVowels(str);
Console.WriteLine(count);
