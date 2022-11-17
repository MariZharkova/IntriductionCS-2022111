// 8. Вывести на экран числа от -N до N

Console.Write("Число N: ");
int N=Convert.ToInt32(Console.ReadLine());

for(int i=-N;i<=N;i=i+1)
{
   Console.Write($"{i} ");
}