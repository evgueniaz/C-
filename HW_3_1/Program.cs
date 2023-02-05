// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821
// 23432 -> да


// do 
//     {
//         Console.WriteLine("Enter a several digit whole number: ");
//     } 
//     while (!(int.TryParse(Console.ReadLine(), out int x)));


int num;
while (true)
{
    Console.WriteLine("Enter a several digit whole number: ");
    num = int.Parse(Console.ReadLine());
    if (num < -9 || num > 9) 
    {
        break;
    }
    Console.WriteLine("You've entered a 1-digit number!!!");  
}

if (num < 0) num = -1 * num;

int num_1 = num;
int num_2 = 0;
while (num_1 > 0)
{
    int remainder = num_1 % 10;
    num_2 = num_2 * 10 + remainder;
    num_1 = num_1 / 10;
}

if (num_2 == num) Console.WriteLine($"Your number {num} is a palindrome!");
else
{
    Console.WriteLine($"Your number {num} is not a palindrome!");
}



