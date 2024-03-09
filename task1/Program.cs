// string str = "Hello world!";
// string str1 = null; // empty string, никуда не ссылается
// string str2 = ""; //ссылается на пустоту = String.Empty.
// string str3 = new string ('x',4);
// string str4 = new string(new [] {'c','d'});
// string str5 = "World";

// // Console.WriteLine(str);
// // Console.WriteLine(str1);
// // Console.WriteLine(str2);
// // Console.WriteLine(str3);
// // Console.WriteLine(str4);

// bool flag = string.IsNullOrEmpty(str1);

// // string strNew = str + str5;
// // str+=str5;
// // str+='w';
// // String.Concat(str,str2);

// // Console.Write(str.ToLower());
// // Console.Write(str.ToUpper());

// // string s3 = str.Trim(); //удаление пробелов
// // string s3 = str.TrimStart(); // удаление только в начале строки
// // string s3 = str.TrimEnd(); // удаление только в конце

// // string str6 = "10.11.12";
// // string [] parts = str6.Split(".");
// // foreach (string item in parts)
// // {
// //     Console.WriteLine(item);
// // }

// string s3 = str.Substring(0,4);
// string s3 = str.Substring(6); // выведет все, что после 6 символа
// Console.WriteLine(s3);


// Задайте массив символов (тип char []). Создайте строку из символов массиваю
// Конструктор строки вида string(char []) не использовать


string GetStingFromArrayChars(char[] chars)
{
    string str = String.Empty;
    foreach (char item in chars)
    {
        str += item;
    }
    return str;
}

char[] chars = { 'H', 'e', 'l', 'l', 'o' };
string str = GetStingFromArrayChars(chars);
Console.WriteLine(str);