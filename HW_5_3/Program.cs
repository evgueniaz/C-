// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());
double[] numbers = new double[array_length];

void Fill_arr(double[] set_nums)
{
    for (int i = 0; i < set_nums.Length; i++)
    {
        double[] temp_nums = new double[set_nums.Length];
        Random rnd = new Random();
        set_nums[i] = rnd.Next(-10, 11);
        temp_nums[i] = rnd.NextDouble();
        set_nums[i] *= temp_nums[i];
        set_nums[i] = Math.Round(set_nums[i], 1);
    }
}

void Array(int length, double[] set)
{
    Console.Write("[");
    for (int j = 0; j < length - 1; j++)
    {
        Console.Write($"{set[j]}; ");
    }
    Console.Write($"{set[length - 1]}]");
}

double max_min_dif = 0;

void Max_min_dif(double[] set_nums)
{
    double min_item = numbers[0];
    double max_item = numbers[0];
    for (int k = 1; k < set_nums.Length; k +=1)
    {
        if (set_nums[k] > max_item) max_item = set_nums[k];
        if (set_nums[k] < min_item) min_item = set_nums[k];
    }
    max_min_dif = Math.Round((max_item - min_item), 1);
    Console.WriteLine($"The minimum value of the array is {min_item}.");
    Console.WriteLine($"The maximum value of the array sum up {max_item}.");
    Console.WriteLine("Difference between the maximum and the minimum numbers is " + max_min_dif);
}

Fill_arr(numbers);
Array(numbers.Length, numbers);
Console.WriteLine();
Max_min_dif(numbers);
