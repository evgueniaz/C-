// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());
int[] numbers = new int[array_length];

void Fill_arr(int[] set_nums)
{
    for (int i = 0; i < set_nums.Length; i++)
    {
        Random rnd = new Random();
        set_nums[i] = rnd.Next(-10, 11);
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

int sum_odd_items = 0;

void Add_odd_items(int[] set_nums)
{
    for (int k = 1; k < set_nums.Length; k +=2)
    {
        sum_odd_items += set_nums[k];
    }
    Console.WriteLine($"Odd elements of the array sum up {sum_odd_items}.");
}

Fill_arr(numbers);
Array(numbers.Length, numbers);
Console.WriteLine();
Add_odd_items(numbers);
