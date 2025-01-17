﻿// 69. Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

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

void OrderLines(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int k = 0; k < a.GetLength(0); k++)
            for (int j = 0; j < a.GetLength(1) - 1; j++)
                if (a[i, j] > a[i, j + 1])
                {
                    int t = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = t;
                }
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k: ");
int k = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] a = Random2DArray(n, k);
Print2DArray(a);
System.Console.WriteLine();
OrderLines(a);
Print2DArray(a);
