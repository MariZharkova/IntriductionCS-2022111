// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int a;
int b;

a = N / 10;
b = N % 10;

if (a == b)
{
   Console.Write($"Цифры одинаковы");
}
else if (a > b)
{
   Console.Write($"Наибольшая цифра: {a}");
}
else
{
   Console.Write($"Наибольшая цифра: {b}");
}
