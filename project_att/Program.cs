// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");
Console.WriteLine();

//----------------------------------------------//
// Тело программы                               //
//----------------------------------------------//

Console.Write("Сколько строк вы будете вводить? ");
string strNumber = new string(Console.ReadLine());
bool resParseLength = int.TryParse(strNumber, out int NumberOfElements);
if (resParseLength)
{
    string[] userArray = GetArray(NumberOfElements);
    string[] decimArray = CreateNewArray(userArray, CountLength(userArray));
    Console.Write($"В первоначальном массиве [{string.Join("; ", userArray)}] содержится: \n");
    Console.Write($"количество строк не длиннее трех = {CountLength(userArray)},\n");
    if (CountLength(userArray)!=0) Console.Write($"новый массив -> [{string.Join("; ", decimArray)}]");
    Console.WriteLine();
}
else Console.Write("Введены некорректные данные");

//----------------------------------------------//
// Метод формирования первоначального массива   //
//----------------------------------------------//

string[] GetArray(int size)
{
    string[] array = new string[size];
    size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i + 1}-я строка: ");
        string? readElement = Console.ReadLine();
        if (readElement != string.Empty) array[i] = readElement!;
        else 
        {
            Console.WriteLine($"Введен пустой элемент, повторите ввод");
            i--;
        }
    }
    return array;
}

//----------------------------------------------//
// Метод подсчета размера усеченного массива        //
//----------------------------------------------//

int CountLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) count++;
    return count;
}

//----------------------------------------------//
// Метод формирования усеченного массива        //
//----------------------------------------------//
string[] CreateNewArray(string[] arr, int size)
{
    int j = 0;
    string[] outArray = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            outArray[j] = arr[i];
            j++;
        }
    }
    return outArray;
}
