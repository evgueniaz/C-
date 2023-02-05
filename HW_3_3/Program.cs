// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num;
while (true)
{
    Console.WriteLine("Enter a whole number greater than 1: ");
    num = int.Parse(Console.ReadLine());
    if (num > 1) 
    {
        break;
    }
    Console.WriteLine("You've entered a number that is not greater than 1!!!");  
}

int x = 1;
while (x <= num)
{
    double result = Math.Pow(x, 3);
    Console.Write($"{result}  ");
    x += 1;
}
