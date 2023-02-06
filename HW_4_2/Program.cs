// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter a whole number: ");
int num = int.Parse(Console.ReadLine());
if (num < 0) num = -1 * num;

int Sum_of_digits(int number)
{
    int res = 0;
    while (number > 0)
    {
        res = res + number % 10;
        number = number / 10;
    }
    return res;
}

int result = Sum_of_digits(num);
Console.WriteLine($"The sum of digits of your number equals {result}");
