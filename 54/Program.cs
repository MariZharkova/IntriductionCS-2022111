// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int Fibona44i(int i)
{
    if (i == 0)
        return 0;
    else if (i == 1 | i == 2)
        return 1;
    else
        return (Fibona44i(i - 1) + Fibona44i(i - 2));
}

int[] CreateRow(int size)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Fibona44i(i);
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

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = CreateRow(N);
Print(a);
