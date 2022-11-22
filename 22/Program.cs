// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число: ");
int n=Convert.ToInt32(Console.ReadLine());

int first = n/10000;
int last = n%10;
int second = (n/1000)%10;
int prenult = (n/10)%10;
 if (first == last & second == prenult)
 {
    Console.WriteLine ("Палиндром");
 }
else
{
    Console.WriteLine ("Не палиндром");
}
