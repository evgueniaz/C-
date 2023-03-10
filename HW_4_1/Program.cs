// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Power(double bas, int exp)
{
    double res = bas;
    for (int i = 1; i < exp; i++)
    {
        res = res * bas;
    }
    return res;
}
Console.WriteLine("Enter a number that will be powered: ");
double basis = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a natural power that will be applied to the first number: ");
int exponent = int.Parse(Console.ReadLine());
if (exponent < 1) Console.WriteLine("You've entered not a natural number!");
else
{
    double result = Power(basis, exponent);
    Console.WriteLine($"{basis} raised to the power of {exponent} is {result}");
}
