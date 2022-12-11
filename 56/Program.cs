// 56. Написать программу копирования массива

int[] RandomIntArray(int size = 10, int min = -10, int max = 10)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max);
    return a;
}

int[] CopyArray(int[] a)
{
    int[] b = new int[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        b[i] = a[i];
    }
    return (b);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)

    {
        System.Console.Write($"{a[i],5}");
    }

}

int[] a = RandomIntArray();
Print(a);
System.Console.WriteLine();
int[] b = CopyArray(a);
Print(b);
