// 90. Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1
// То есть, 2 бита, потом еще 3 бита, потом еще 3 бита и еще 1 бит. Переводим биты в десятичное представление.

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    {
        System.Console.Write($"{a[i],5}");
    }
    System.Console.WriteLine();
}

int[] TransformToNumbers(int[] data, int[] info)
{
    int[] result = new int[info.Length];
    int k = 0;
    for(int i = 0; i < info.Length; i++)
    {
        int number = 0;
        for (int degree = info[i]; degree > 0; degree--)
        {
            number += data[k] * Convert.ToInt32(Math.Pow(2, degree - 1));
            k++;
        }
        result[i] = number;
    }
    return result;
}

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
System.Console.WriteLine("Data array:");
Print(data);
System.Console.WriteLine("Info array:");
Print(info);
int[] result = TransformToNumbers(data, info);
System.Console.WriteLine("Transformed into array of numbers:");
Print(result);

