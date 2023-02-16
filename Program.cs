// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

using static System.Console;
Clear();

// string[] WorldArray = {"hello", "2", "world", ":-)", "123"};
Write("Задайте любой массив из любых символов через пробел: ");
string[] WorldArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] NewArray = new string[WorldArray.Length];


for (int i = 0; i < WorldArray.Length; i++)
{
    if (WorldArray[i].Length > 3)
    {
        WorldArray[i] = " ";
    }
    Write(WorldArray[i] + " ");
}


