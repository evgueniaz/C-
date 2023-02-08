// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] numbers = new int[8];

void Arr(int[] set_nums)
{
    for (int i = 0; i < set_nums.Length; i++)
    {
        Random rnd = new Random();
        set_nums[i] = rnd.Next();
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

Arr(numbers);
Array(numbers.Length, numbers);
