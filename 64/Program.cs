// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Random2DArray(int n, int k, int min = 0, int max = 10)
{
    int[,] a = new int[n, k];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < k; j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

int[,] ChangeToSqr(int n, int k, int[,] a)
{
    int[,] b = new int[n, k];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < k; j++)
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                b[i, j] = (a[i, j]) * (a[i, j]);
            }
            else
            {
                b[i, j] = a[i, j];
            }
    return b;
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k: ");
int k = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] a = Random2DArray(n, k);
Print2DArray(a);
System.Console.WriteLine();
int[,] b = ChangeToSqr(n, k, a);
Print2DArray(b);
