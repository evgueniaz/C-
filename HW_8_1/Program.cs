// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numMinValue = SetNumber("Min Value");
int numMaxValue = SetNumber("Max Value");
var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
Console.WriteLine();
DecreasingRaws(matrix);
Print(matrix);

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

void DecreasingRaws(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1) - 1; l++)
        {
            for (int k = l+1; k < matr.GetLength(1); k++)
            {
                int temp;
                if (matr[i,l] < matr[i,k]) 
                {
                    temp = matr[i,l];
                    matr[i,l] = matr[i,k];
                    matr[i,k] = temp;
                }
            }
        }
    }
}