// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=123,int min=-100,int max=100)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max+1);
    }

    return a;
}

int FindAmount(ref int[] a)
{
    int count = 0;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]>=10 && a[i]<=99)
        {
            count++;
        }
    }
        
    return count;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)

    {
        System.Console.Write($"{a[i], 5}");
    }
        
}

int[] a = RandomIntArray(123, -200, 200);
Print(a);
Console.WriteLine();
Console.WriteLine($"{FindAmount(ref a)}");
