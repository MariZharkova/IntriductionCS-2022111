﻿// 2. С клавиатуры вводятся два вещественных числа. 
// Проверять, является ли одно из них квадратом второго (блок-схема)

Console.Write("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine($"{b} является квадратом {a}");
} 
if (b * b == a) 
{
    Console.WriteLine($"{a} является квадратом {b}");
}
