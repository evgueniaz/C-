// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

Console.WriteLine("Enter a whole number greater than 1: ");
int num = int.Parse(Console.ReadLine());
int x = 1;
while (x <= num)
{
    double result = Math.Pow(x, 3);
    Console.Write($"{result}  ");
    x += 1;
}
