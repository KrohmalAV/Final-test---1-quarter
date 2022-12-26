/*
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "-2", "1567", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Clear();
Console.Write("Введите элементы массива, разделяя их запятыми без пробелов: ");
string line = Console.ReadLine()!;
string[] array = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
int i = 0;
int count = 0;
for (i = 0; i < array.Length; i++)
    if (array[i].Length < 4)
        count++;
if (count == 0)
    Console.WriteLine("В заданном массиве нет элементов, длина которых меньше 4");
else
{
    string[] newArray = new string[count];
    int j = 0;
    for (i = 0; i < array.Length; i++)
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    Console.Write($"[{string.Join(", ", newArray)}]");
}
