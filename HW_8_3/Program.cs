// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
int numRows1 = SetNumber("Number of rows of the first Matrix");
int numColumns1 = SetNumber("Number of columns of the first Matrix");
int numMinValue1 = SetNumber("Min Value of the first Matrix");
int numMaxValue1 = SetNumber("Max Value of the first Matrix");
var matrix1 = GetMatrix(numRows1, numColumns1, numMinValue1, numMaxValue1);
Print(matrix1);
Console.WriteLine();

int numRows2 = SetNumber("Number of rows of the second Matrix");
int numColumns2 = SetNumber("Number of columns of the second Matrix");
int numMinValue2 = SetNumber("Min Value of the second Matrix");
int numMaxValue2 = SetNumber("Max Value of the second Matrix");
var matrix2 = GetMatrix(numRows2, numColumns2, numMinValue2, numMaxValue2);
Print(matrix2);
Console.WriteLine();
MatricesProduct(matrix1, matrix2);

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

void MatricesProduct (int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        Console.WriteLine ("The given matrices cannot be multiplied.");
    }
    else
    {
        int[,] product_matrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int l = 0; l < matr2.GetLength(1); l++)
            {
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    product_matrix[i,l] = product_matrix[i,l] + matr1[i,k] * matr2[k,l];
                }
            }
        }
        Console.WriteLine("The product of the given matrices is ");
        Print(product_matrix);
    }
}


