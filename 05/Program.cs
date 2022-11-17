// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.Write("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число c: ");
double c=Convert.ToDouble(Console.ReadLine());
double max;
max = a;

if (max < b)
{
    max = b;
} 
else
{
   if (max < c)
   {
    max = c;
   }
}
Console.WriteLine($"Максимальное значение: {max}");
