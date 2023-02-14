// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());
int[] numbers = new int[array_length];
for (int i = 0; i < array_length; i++)
{
    Console.WriteLine("Enter a positive or a negative number to be placed in the array: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

void Print_Array(int length, int[] set)
{
    Console.Write("[");
    for (int j = 0; j < length - 1; j++)
    {
        Console.Write($"{set[j]}, ");
    }
    Console.Write($"{set[length - 1]}]");
}

Print_Array(array_length, numbers);
Console.WriteLine();

int Count_positive(int[] set)
{
    int count = 0;
    for (int i = 0; i < set.Length; i++)
    {
        if (set[i] > 0) count++;
    }
    return count;
}


Console.WriteLine($"There are {Count_positive(numbers)} positive numbers in your array.");
