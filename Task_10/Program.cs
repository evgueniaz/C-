// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Enter x-coordinate of the first point: ");
float x_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter y-coordinate of the first point: ");
float y_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter z-coordinate of the first point: ");
float z_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter x-coordinate of the second point: ");
float x_2 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter y-coordinate of the second point: ");
float y_2 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter z-coordinate of the second point: ");
float z_2 = float.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2) + Math.Pow((z_2 - z_1), 2));
Console.WriteLine($"Distance between these points equals {distance}");
