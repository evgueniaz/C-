// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numDepth = SetNumber("Depth");

var uniqueValues = UniqueNums(numRows, numColumns, numDepth);
var matrix = GetMatrix(numRows, numColumns, numDepth, uniqueValues);
Print(matrix);
UniqueNums(numRows, numColumns, numDepth);

int[] UniqueNums(int rows, int columns, int depth)
{
    int[] uniqueNums = new int[rows*columns*depth];
    for (int i = 0; i < uniqueNums.Length; i++)
    {
        var el = new Random().Next(10, 100);
        if (uniqueNums.Contains(el)) i--;
        else
        {
            uniqueNums[i] = el;
        }
    }
    return uniqueNums;
}


int[,,] GetMatrix(int rows, int columns, int depth, int[] values)
{
    int[,,] matr = new int[rows, columns, depth];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {   
                matr[i, j, k] = values[count];
                count++;
            }
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


void Print(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
} 

