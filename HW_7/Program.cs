// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Start();

void Start()
{
    while (true)
    {
        // Console.ReadLine();
        // Console.Clear();

        Console.WriteLine("47) Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        Console.WriteLine("50) Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine("52) Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("62) Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4");
        Console.WriteLine("0) End");
        Console.WriteLine();

        int numTask = SetNumber("TaskNumber");

        switch (numTask)
        {
            case 0: 
                return; 
                break;
            case 47:
                Console.Clear();
                int numRows = SetNumber("Rows");
                int numColumns = SetNumber("Columns");
                int numMinValue = SetNumber("Min Value");
                int numMaxValue = SetNumber("Max Value");
                var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
                Print(matrix);

                double[,] GetMatrix(int rows, int columns, int min, int max)
                {
                    double[,] matr = new double[rows, columns];
                    for (int i = 0; i < rows; i++)
                    {
                        for (int l = 0; l < columns; l++)
                        {
                            Random rnd = new Random();
                            matr[i, l] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 2);
                        }
                    }
                    return matr;
                }

                void Print(double[,] matr)
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

                break;

            case 50:
                Console.Clear();
                int numRows1 = SetNumber("Rows");
                int numColumns1 = SetNumber("Columns");
                int numMinValue1 = SetNumber("Min Value");
                int numMaxValue1 = SetNumber("Max Value");
                var matrix1 = GetMatrix1(numRows1, numColumns1, numMinValue1, numMaxValue1);
                Print1(matrix1);
                Console.WriteLine();
                Console.WriteLine("Enter an integer number to be found: ");
                int seek_number = int.Parse(Console.ReadLine());
                
                Console.WriteLine(SeekNumber(seek_number, matrix1));
                Console.WriteLine();

                int[,] GetMatrix1(int rows, int columns, int min, int max)
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

                string SeekNumber(int num, int[,] matr)
                {
                    string res = "No such number in the matrix!";
                    foreach (int el in matr)
                    {
                        if (el == num)
                        {
                        res = Convert.ToString(num);
                        }
                    }
                    return res;
                }
                break;

            case 52:
                // Input();
                Console.Clear();
                int numRows2 = SetNumber("Rows");
                int numColumns2 = SetNumber("Columns");
                int numMinValue2 = SetNumber("Min Value");
                int numMaxValue2 = SetNumber("Max Value");
                var matrix2 = GetMatrix2(numRows2, numColumns2, numMinValue2, numMaxValue2);
                Print1(matrix2);
                Console.WriteLine();
                ColumnAverage(matrix2);
                Console.WriteLine();

                int[,] GetMatrix2(int rows, int columns, int min, int max)
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

                void ColumnAverage(int[,] matr)
                {
                    double[] mean_array = new double[matr.GetLength(1)];
                    
                    for (int l = 0; l < matr.GetLength(1); l++)
                    {
                        double column_sum = 0;
                        for (int i = 0; i < matr.GetLength(0); i++)
                        {
                            column_sum += matr[i,l];
                        }
                        double mean = Math.Round((column_sum / matr.GetLength(0)), 2);
                        Console.WriteLine($"The average value of column {l + 1} is {mean}");
                        mean_array[l] = mean;
                    }
                    Console.WriteLine("The average of each column is: " + String.Join(" ", mean_array));
                }
                break;

            case 62:
                Console.Clear();
                var matrix3 = GetMatrix3();
                Print3(matrix3);
                Console.WriteLine();
                
                int[,] GetMatrix3()
                {
                    int[,] matr = new int[4, 4];
                    int k = 1;
                    for (int l = 0; l < 4; l++)
                    {
                        int i = 0;
                        matr[i,l] = k; 
                        k += 1;
                    }
                    for (int i = 1; i < 4; i += 1)
                    {
                        int l = 3;
                        matr[i,l] = k;
                        k += 1;
                    }
                    
                    for (int l = 2; l >= 0; l += -1)
                    {
                        int i = 3;
                        matr[i,l] = k;
                        k += 1;
                    }
                    for (int i = 2; i > 0; i += -1)
                    {
                        int l = 0;
                        matr[i,l] = k;
                        k += 1;
                    }
                    for (int l = 1; l < 3; l++)
                    {
                        int i = 1;
                        matr[i,l] = k; 
                        k += 1;
                    }
                    for (int l = 2; l > 0; l += -1)
                    {
                        int i = 2;
                        matr[i,l] = k; 
                        k += 1;
                    }
                    return matr;
                }

                void Print3(int[,] matr)
                {
                    for (int i = 0; i < matr.GetLength(0); i++)
                    {
                        for (int l = 0; l < matr.GetLength(1); l++)
                        {
                            System.Console.Write(string.Format("{0:00}", matr[i, l]) + " ");
                        }
                        System.Console.WriteLine();
                    }
                }   
                break;

            default: Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Print1(int[,] matr)
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
