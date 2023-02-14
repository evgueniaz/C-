// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter positive or negative numbers to be placed into an array separated by space: ");
string array = Console.ReadLine();
string[] nums = array.Split(' ');

int[] numbers = new int[nums.Length];

int[] Fill_array(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        numbers[i] = Convert.ToInt32(arr[i]);
    }
    return numbers;
}

Fill_array(nums);
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
Console.WriteLine();
