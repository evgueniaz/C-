// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number corresponding to a day of the week from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <1 || number > 7) Console.WriteLine("You've entered a number out of the interval");
else if (number == 6 || number == 7) Console.WriteLine("Yes, it's weekend!");
else
{
    Console.WriteLine("No, it's a working day...");
}
