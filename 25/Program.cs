// 25. Вывести на экран кубы чисел от 1 до N

double Cube (int number)
{
    return Math.Pow(number, 3);
}
Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < (N + 1); i++)
{
   System.Console.WriteLine($"{i}^3 = {Cube(i)}");
}
