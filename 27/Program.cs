// Возведите число А в натуральную степень B используя цикл

int Power (int number, int pow)
{
    int result = number;
    while (pow!=1)
    {
        result = result * number;
        pow = pow-1;
    }
    return result;
}

Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int B=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A}^{B} = {Power(A, B)}");