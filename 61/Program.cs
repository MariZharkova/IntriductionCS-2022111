// 61 Показать двумерный массив размером m×n заполненный вещественными случайными числами


double[,] Random2DArray(int m, int n, int min = 0, int max = 1000)
{
    double[,] a = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            a[i, j] = Convert.ToDouble(random.Next(min, max + 1)) / 100;
    return a;
}

void Print2DArray(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],7}");
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
System.Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = Random2DArray(m, n);
Print2DArray(a);
