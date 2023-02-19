// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numMinValue = SetNumber("Min Value");
int numMaxValue = SetNumber("Max Value");
var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
Console.WriteLine();
Console.WriteLine();

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matr[i, l] = new Random().Next(min, max);
        }
    }
    return matr;
}

Console.WriteLine("Enter a row number  ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a column number  ");
int l = int.Parse(Console.ReadLine());

if (i < matrix.GetLength(0) && l < matrix.GetLength(1))
{
    Console.Write($"The corresponding number is {matrix[i, l]}");
}

else
{
    Console.WriteLine($"There is no such number in the array!");
}

int SetNumber(string numberName)
{
    Console.Write($"Enter {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            System.Console.Write(matr[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}   
