// Задача состоит в написании текста программы, которая из имеющегося массива
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// { "hello", "123", "2", "world", ":-)" } => { "123", "2", ":-)" }

string[] initialArray = new string[] { "hello", "123", "2", "world", ":-)" };
string[] resultArray = new string[initialArray.Length];
const int maxSize = 3;
byte j = 0;

for (byte i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= maxSize)
        resultArray[j++] = initialArray[i];
}
