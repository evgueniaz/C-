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

Fill_array(numbers);
Console.WriteLine();

double x = (data[2] - data[0])/(data[1] - data[3]);
double y = data[1] * x + data[0];
Console.WriteLine($"The lines intersect at the point ({x}; {y})");
Console.WriteLine();

