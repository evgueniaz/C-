// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Start();

void Start()
{
    while (true)
    {
        Console.WriteLine("64) Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
        Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("68) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("0) End");
        Console.WriteLine();

        int numTask = SetNumber("TaskNumber");

        switch (numTask)
        {
            case 0: 
                return; 
                break;
            case 64:
                Console.Clear();
                int natNum = EnterNumber("a natural number");
                Console.Write($"\"");
                NatArray(natNum, 1);
                Console.Write($"1\"\n\n\n");
                                
                int NatArray (int number, int count)
                {
                    
                    if (number < 2) return count;
                    Console.Write($"{number}, ");
                    number--;
                    return NatArray(number, count);
                }

                break;

            case 66:

                Console.Clear();
                int numM = EnterNumber("first natural number");
                int numN = EnterNumber("a second natural number");
                int sum = 0; 
                if (numM <= numN) NumSum(numM, numN);
                else NumSum(numN, numM);
                Console.Write($"The sum of natural numbers from {numM} to {numN} equals {sum}\n\n\n");
                                                
                int NumSum(int num1, int num2)
                {
                    
                    sum += num1;
                    if (num1 >= num2) return sum;
                    num1++;
                    return NumSum(num1, num2);
                }

                break;

            case 68:
                
                Console.Clear();
                int numA = EnterNumber("first natural number");
                int numB = EnterNumber("a second natural number");
                var result = Ackermann(numA, numB);
                Console.WriteLine($"The value of A({numA}, {numB}) is {result}\n\n");

                int Ackermann(int num1, int num2)
                {
                    if (num1 == 0) return num2 + 1;
                    else if (num1 > 0 && num2 == 0) return Ackermann(num1 - 1, 1);
                    return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
                }

                break;

            default: Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int EnterNumber(string text) 
{
    Console.Write($"Enter {text}: ");
    int result;
    while (true)
    { 
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            return result;

        System.Console.WriteLine($"Error. Enter {text}");
    }
    return 0;
}

