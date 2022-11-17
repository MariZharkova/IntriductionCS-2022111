// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 

Console.Write("Введите угол a: ");
double a=Convert.ToDouble(Console.ReadLine());
double y=Math.Sin(a);
Console.WriteLine($"y = {y}");
