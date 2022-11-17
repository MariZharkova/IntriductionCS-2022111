// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int last;

last = N % 10;
Console.Write($"{last} ");
