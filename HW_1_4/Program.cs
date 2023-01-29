// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

if(number <= 1)
{
    Console.Write("There are no positive even numbers less than your number");
}
else
{
    while(count <= number - 2)
    {
        Console.Write(count);
        Console.Write(", ");
        count += 2;
    }
    Console.Write(count);
}


