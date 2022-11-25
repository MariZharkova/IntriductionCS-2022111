// 24. Вывести на экран таблицу квадратов чисел от 1 до N

int Square (int number)
{
    return number * number;
}
Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{"Число"}\t{"Квадрат"}");
for (int i = 1; i < (N + 1); i++)
{
   System.Console.WriteLine($"{i}\t{Square(i)}");
} 
