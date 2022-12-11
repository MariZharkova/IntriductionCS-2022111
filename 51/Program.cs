// 51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int[] EnterArray(int size)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return (a);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)

    {
        System.Console.Write($"{a[i],5}");
    }

}

int CountPositive(int[] a)
{
    int positive = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0)
        {
            positive++;
        }

    }

    return positive;
}

Console.Write("Введите число элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = EnterArray(N);
Print(a);
Console.WriteLine();
Console.WriteLine(CountPositive(a));


