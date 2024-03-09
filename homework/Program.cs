// Задача 1. Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Задача 2. Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Задача 3. Задайте произвольную строку. Выясните, является ли она палиндромом.

// Задача 4. Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string GetStingFrom2DArrayChars(char[,] chars)
{
    string str = String.Empty;
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            str += chars[i, j];
        }
        str += " ";
    }
    return str;
}

bool IsPolindrom(string str)
{
    int temp = 0;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] == str[str.Length - i - 1]) temp++;
    }
    if (temp == str.Length / 2) return true;
    else return false;
}

void PrintResult(string str)
{
    if (IsPolindrom(str)) Console.Write("Строка является полиндромом");
    else Console.Write("Строка не является полиндромом");

}

string[] ReverseOrderString(string str)
{
    string[] partsStringArray = str.Split(" ");
    return partsStringArray;
}

void PrintReverseString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[array.Length - i - 1]} ");
    }
}

char[,] chars = { { 'H', 'e' }, { 'W', 'o' } };
string str = GetStingFrom2DArrayChars(chars);
//Console.WriteLine(str);

string str1 = "GHt3kthkTYHHKBVF";
//Console.WriteLine(str1.ToLower());

string str2 = "шалаш";
//PrintResult(str1);

//string [] stringArray = {"Hello","my","World"};

string str3 = "Hello my World";
PrintReverseString(ReverseOrderString(str3));