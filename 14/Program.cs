// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, 
// вывести остаток от деления a на b.

Console.Write("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());

if ((a % b) == 0)
{
   Console.Write($"Число {a} кратно числу {b}.");
}
else
{
   Console.Write($"Остаток от деления: {a % b}");
}