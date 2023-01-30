// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999) Console.WriteLine($"You've entered not a 3-digit number!");
else
{
    int hundred = number / 100;
    int result = (number - hundred * 100) / 10;
    Console.WriteLine(result);
}
