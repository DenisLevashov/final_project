// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

using static System.Console;
Clear();

WriteLine("Задайте массив через пробел:");
string[] FirstArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] SecondArray = new string[FirstArray.Length - 1];
WriteLine();
PrintArray(FirstArray);
WriteLine("===>");
NewArray(FirstArray, SecondArray);
PrintArray(SecondArray);

void NewArray(string[] WorldArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < WorldArray.Length; i++)
    {
        if (WorldArray[i].Length <= 3)
        {
            SecondArray[count] = WorldArray[i];
            count++;
        }
    }
}
void PrintArray(string[] InArray)
{
    Write("[");
    for (int i = 0; i < InArray.Length - 1; i++)
    {
        Write($"{InArray[i]}, ");
    }
    WriteLine($"{InArray[InArray.Length - 1]}]");
}


