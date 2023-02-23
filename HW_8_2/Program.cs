// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numMinValue = SetNumber("Min Value");
int numMaxValue = SetNumber("Max Value");
var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
Console.WriteLine();
var res_array = RowSum(matrix);
MinRowSum(res_array);

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

int[] RowSum (int[,] matr)
{
    int[] RowSumsArray = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            RowSumsArray[i] += matr[i,l];
        }
    }
    return RowSumsArray;
}

void MinRowSum(int[] matr)
{
    int min_sum = matr[0];
    int row_min_sum = 1;
    for (int i = 1; i < matr.Length; i++)
    {
        if (matr[i] < min_sum)
        {
            min_sum = matr[i];
            row_min_sum = i + 1;
        }
    }
    System.Console.WriteLine($"The minimal sum of elements equals {min_sum}.The row with minimal sum of elements is {row_min_sum}.");
}