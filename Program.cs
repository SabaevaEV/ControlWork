// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] GetArray()
{
    Console.WriteLine("Введите элементы массива через пробел: ");
    string[] arr = new string [] {};
    return Console.ReadLine()!.Split();

}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string [] SortLength (string [] arr)
{
    string [] sortArray = new string [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i].Length <= 3)
       {
        sortArray[i] = arr [i];
       } 
    }
    return sortArray;
}

string[] array = GetArray();
//PrintArray(array);
string [] newArray = SortLength(array);
Console.WriteLine ("Элементы массива, длина строк которых меньше или равна 3: ");
PrintArray(newArray);
