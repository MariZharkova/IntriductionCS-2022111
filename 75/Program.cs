// 75. Написать программу вычисления функции Аккермана - 5*

int Ackermann(int m, int n)
{
    if(m > 0)
    {
        if (n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else if (n == 0)
            return Ackermann(m - 1, 1);
    }
    return n + 1;
}

for (int m = 0; m <= 3; m = m+1)
{
    for (int n = 0; n <= 4; n = n+1)
    {
        Console.WriteLine("A({0}, {1}) = {2}", m, n, Ackermann(m, n));
    }
}