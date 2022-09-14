// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ArrayPrint(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} \t");
    }
}

string[] StringOfThreeChar(string[] arr)
{
    string[] newArr = new string[5];
    for (int i = 0, count = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}

string[] firstArray = new string[] { "Hello", "2", "world", ":-)" };
string[] secondArray = new string[] { "1234", "1567", "-2", "computer science" };
string[] thirdArray = new string[] { "Russia", "Denmark", "Kazan" };
ArrayPrint(firstArray);
System.Console.WriteLine();
ArrayPrint(StringOfThreeChar(thirdArray));
