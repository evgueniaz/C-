// выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1
// Если N = 7 --> 0 1 1 2 3 5 8

Console.WriteLine("Enter a whole non-negative number: ");
int N = int.Parse(Console.ReadLine());
int Fibonacci (int n)
{
    if (n == 0) return 0;
    else if (n == 1) return 1;
    else
    {
        return Fibonacci(n - 1) + Fibonacci (n - 2);
    }
}

int res = Fibonacci(N - 1);
Console.WriteLine($"{N}-th Fibonacci number is {res}");

int[] Fibonacci_Array (int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = Fibonacci(i);
    }
    return arr;
}

Console.WriteLine(String.Join (" ", Fibonacci_Array(N)));
