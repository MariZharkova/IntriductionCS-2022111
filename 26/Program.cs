// 26. Найти сумму чисел от 1 до А

int Sum (int number)
{
    return ((1 + number) * number)/2;
}

Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма равна {Sum (A)}");