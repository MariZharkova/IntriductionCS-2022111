// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

int Sum (int number)
{
    int k = number;
    int sum = 0;
    while (k!=0)
    {
        sum = sum + (k % 10);
        k = k/10;
    }
return sum;
}

Console.WriteLine($"Сумма цифр числа: {Sum (N)}");
