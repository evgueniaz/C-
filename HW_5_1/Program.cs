// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());
int[] numbers = new int[array_length];

void Fill_arr(int[] set_nums)
{
    for (int i = 0; i < set_nums.Length; i++)
    {
        Random rnd = new Random();
        set_nums[i] = rnd.Next(100, 1000);
    }
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

int count = 0;

void Count_even_items(int[] set_nums)
{
    for (int k = 0; k < set_nums.Length; k++)
    {
        if (set_nums[k] % 2 == 0) count += 1;
    }
    Console.WriteLine($"There are {count} even numbers in the array.");
}

Fill_arr(numbers);
Array(numbers.Length, numbers);
Console.WriteLine();
Count_even_items(numbers);
