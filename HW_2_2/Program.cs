// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100) Console.WriteLine($"There's no third digit!");
else
{
    if (number < 0) number = number * (-1);
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"The third digit of your number from the left is {result}");
}
