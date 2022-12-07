// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
// Создайте массив, который является произведением пар чисел в одномерном массиве a. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] RandomIntArray(int size=10, int min=1, int max=10)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max+1);
    }

    return a;
}

int[] MultiplicationPairs(int[] a, int N)
{
    int[] b = new int[(N+1)/2];
    for (int i = 0; i < b.Length; i++)
    {
        b[i] = a[i] * a[(N-1-i)];
    }

    return b;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)

    {
        System.Console.Write($"{a[i], 5}");
    }
        
}

Console.Write("Введите число элементов массива N: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] a = RandomIntArray(N, 1, 10);
Print(a);
int [] b = MultiplicationPairs (a, N);
Console.WriteLine();
Print(b);

