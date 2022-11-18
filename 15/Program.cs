// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=0;
int res;
int a = N;

while (a != 0)
{
    a = a/10;
    i = i + 1;
}
if (i <= 2)
{
    Console.Write("NO");
}
else
{
    res = (N/(Convert.ToInt32(Math.Pow(10,(i-3)))))%10;
    Console.Write($"Третья цифра: {res}");
}
