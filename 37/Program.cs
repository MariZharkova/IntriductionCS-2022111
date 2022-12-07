// 37. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] RandomIntArray(int size=10,int min=100,int max=999)
{
    int[] a = new int[size];
    Random random=new Random();
    for(int i = 0; i < size; ++i )
    {
        a[i] = random.Next( min, max + 1 );
    }

    return a;
}

void CountOddAndEven(int[] a, ref int countEven, ref int countOdd)
{
    countEven = 0;
    countOdd = 0;
    for(int i = 0; i < a.Length; ++i)
    {
         if (a[i] % 2 == 0)
         {
            countEven++;
         }
         else 
         {
            countOdd++;
         }
    }

}

void Print(int[] a)
{
    for(int i = 0; i < a.Length; ++i)
    {
        System.Console.Write($"{a[i],5}");
    }
}

int[] a =  RandomIntArray(10,100,999);
Print(a);
int countEven = 0;
int countOdd = 0;
CountOddAndEven(a, ref countEven, ref countOdd);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел: {countEven}");
System.Console.WriteLine($"Количество нечетных чисел: {countOdd}");
