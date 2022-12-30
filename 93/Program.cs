// 93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// (кажется, в примере приведено неверно, просто перемножены элементы на соответствующих позициях)

int[,] Random2DArray(int n, int m, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
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

int[,] MultiplyArrays(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
        {
             throw new Exception("Умножение невозможно!"); 
        }
     
    int[,] mult = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < b.GetLength(1); j++)
            {
                mult[i, j] = 0;
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    mult[i, j] += a[i,k] * b[k,j];
                }
            }
              
    return mult;
}

int n = 3;
int m = 3;
int[,] a = Random2DArray(n, m);
Print2DArray(a);
System.Console.WriteLine();
int[,] b = Random2DArray(n, m);
Print2DArray(b);
System.Console.WriteLine();
int[,] mult = MultiplyArrays(a, b);
Print2DArray(mult);