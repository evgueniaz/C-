// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());

int[] Fill_arr(int size, int min_val, int max_val)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(min_val, max_val + 1);
    }
    return numbers;
}

void Array(int length, int[] set)
{
    Console.Write("[");
    for (int j = 0; j < length - 1; j++)
    {
        Console.Write($"{set[j]}, ");
    }
    Console.Write($"{set[length - 1]}]");
}

int Count_even_items(int[] set_nums)
{
    int count = 0;
    for (int k = 0; k < set_nums.Length; k++)
    {
        if (set_nums[k] % 2 == 0) count += 1;
    }
    return count;
}

int[] set_numbers = Fill_arr(array_length, 100, 1000);
Array(set_numbers.Length, set_numbers);
Console.WriteLine();
int count_even = Count_even_items(set_numbers);
Console.WriteLine($"There are {count_even} even numbers in the array.");