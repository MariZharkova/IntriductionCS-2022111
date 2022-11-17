//9. Вывести на экран четные числа от 1 до N

Console.Write("Число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
while(i<=N)
{
    Console.Write($"{i} ");
    i=i+2;
}
Console.WriteLine();
for(int j=1;j<=N;j=j+1)
{
    if (j%2==0)
    {
        Console.Write($"{j} ");
    }
}
