// Задача 1: Задайте двумерный массив символов (тип char [,]).
//Создать строку из символов этого массива.
using System.Reflection.Metadata;
using System.Xml.XPath;

char[,] FillArray(int rows, int columns)
{
    char[,] result = new char[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Convert.ToChar(new Random().Next(33, 127));
        }
    }
    return result;
}

void PrintArray(char[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == arr.GetLength(1)-1) Console.WriteLine($"{arr[i, j]}]");
            else Console.Write($"{arr[i, j]}, ");
        }
    }
}
char[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine();
string CharArrayToString(char[,] arr)
{
    string result = String.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i,j];
        }
    }
    return result;
}
Console.WriteLine(CharArrayToString(array));