// 30. Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int Factorial (int number)
{
    if (number == 0)
    {
        return 1;
    }
    else
        return number * Factorial(number - 1);
}

Console.WriteLine($"{N}! = {Factorial (N)}");




