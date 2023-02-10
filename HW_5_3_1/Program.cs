// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());

double[] Fill_arr(int size, int min_val, int max_val)
{
    double[] numbers = new double[size];
    double[] temp_nums = new double[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(min_val, max_val + 1);
        temp_nums[i] = new Random().NextDouble();
        numbers[i] *= temp_nums[i];
        numbers[i] = Math.Round(numbers[i], 1);
    }
    return numbers;
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

double Max_min_dif(double[] set_nums)
{
    double max_min_dif = 0;
    double min_item = set_nums[0];
    double max_item = set_nums[0];
    for (int k = 1; k < set_nums.Length; k +=1)
    {
        if (set_nums[k] > max_item) max_item = set_nums[k];
        if (set_nums[k] < min_item) min_item = set_nums[k];
    }
    max_min_dif = Math.Round((max_item - min_item), 1);
    Console.WriteLine($"The minimum value of the array is {min_item}.");
    Console.WriteLine($"The maximum value of the array sum up {max_item}.");
    return max_min_dif;
}

double[] set_numbers = Fill_arr(array_length, -10, 10);
Array(set_numbers.Length, set_numbers);
Console.WriteLine();
double difference_of_values = Max_min_dif(set_numbers);
Console.WriteLine("Difference between the maximum and the minimum numbers is " + difference_of_values);

