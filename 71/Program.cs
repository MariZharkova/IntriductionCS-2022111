// 71. Показать натуральные числа от N до 1, N задано

int N=10;

void PrintRecurent (int i)
{
    if (i < 1) 
    {
        return;
    }
    System.Console.Write(i);
    PrintRecurent(i - 1);
}

PrintRecurent(N);
