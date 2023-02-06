// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter a number of elements in your array: ");
int array_length = int.Parse(Console.ReadLine());
int[] numbers = new int[array_length];
for (int i = 0; i < array_length; i++)
{
    Console.WriteLine("Enter a number to be placed in the array: ");
    numbers[i] = int.Parse(Console.ReadLine());
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

Array(array_length, numbers);
