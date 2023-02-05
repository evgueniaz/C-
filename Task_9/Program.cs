Console.WriteLine("Введите номер четверти: ");
int quartil = int.Parse(Console.ReadLine());
if(quartile < 1 || quartil > 4) Console.WriteLine("Введен некорректный номер четверти!");
if(quartile == 1) Console.WriteLine("x > 0, y > 0");
else if(quartile == 2) Console.WriteLine("x < 0, y > 0");
else if(quartile == 3) Console.WriteLine("x < 0, y < 0");
else if (quartile == 4) Console.WriteLine("x > 0, y < 0");

