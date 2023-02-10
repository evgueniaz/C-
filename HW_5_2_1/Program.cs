// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int Add_odd_items(int[] set_nums)
{
    int sum_odd_items = 0;
    for (int k = 1; k < set_nums.Length; k +=2)
    {
        sum_odd_items += set_nums[k];
    }
    return sum_odd_items;
}

int[] set_numbers = Fill_arr(array_length, -10, 10);
Array(set_numbers.Length, set_numbers);
Console.WriteLine();
int sum_odd_elems = Add_odd_items(set_numbers);
Console.WriteLine($"Odd elements of the array sum up {sum_odd_elems}.");
