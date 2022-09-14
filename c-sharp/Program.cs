// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} \t");
    }
}

string[] GetArrayFromStringLessThreeChar(string[] arr, int size)
{
    string[] newArr = new string[size];
    for (int i = 0, count = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = arr[i];
        }
    }
    return newArr;
}

void CheckForThreCharInStringArray(string[] arr)
{
    int validationCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            validationCount++;
        }
    }
    if (validationCount == 0)
    {
        System.Console.WriteLine("В массиве нет подходящих элементров");
    }
    else
    {
        PrintArray(GetArrayFromStringLessThreeChar(arr, validationCount));
    }
}

string[] firstArray = new string[] { "Hello", "2", "world", ":-)" };
string[] secondArray = new string[] { "1234", "1567", "-2", "computer science" };
string[] thirdArray = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(firstArray);
System.Console.WriteLine();
CheckForThreCharInStringArray(firstArray);
System.Console.WriteLine();
PrintArray(secondArray);
System.Console.WriteLine();
CheckForThreCharInStringArray(secondArray);
System.Console.WriteLine();
PrintArray(thirdArray);
System.Console.WriteLine();
CheckForThreCharInStringArray(thirdArray);
System.Console.WriteLine();
