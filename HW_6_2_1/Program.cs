// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter a y-intercept and a slope of the first line and of the second line separated by spaces b1, k1, b2, k2: ");
string nums = Console.ReadLine();
string[] numbers = nums.Split(' ');

double[] data = new double[numbers.Length];

double[] Fill_array(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        data[i] = Convert.ToDouble(arr[i]);
    }
    return data;
}


void Lines_position (double[] arr)
{
    if (arr[0] == arr[2] && arr[1] == arr[3])
    Console.WriteLine("The lines coincide");
    else if (arr[0] != arr[2] && arr[1] == arr[3])
    Console.WriteLine("The lines are parallel");
    else
    {
        double x = (arr[2] - arr[0])/(arr[1] - arr[3]);
        double y = arr[1] * x + arr[0];
        Console.WriteLine($"The lines intersect at the point ({x}; {y})");
    }
    
}

Fill_array(numbers);
Console.WriteLine();
Lines_position(data);
WriteLine();



