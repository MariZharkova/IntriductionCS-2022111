// 70. Показать натуральные числа от 1 до N, N задано

int N=10;

void PrintRecurent (int max, int i)
{
    if (i > max)
    {
        return;
    }
    System.Console.Write(i);
    PrintRecurent(max, i + 1);
}

PrintRecurent(N, 1);