// 4. По заданному с клавиатуры номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int day=Convert.ToInt32(Console.ReadLine());

if ((day <= 0)|(day > 7))
{
    Console.WriteLine($"Такого дня недели не существует");
}
if (day == 1)
{
   Console.WriteLine($"Понедельник"); 
}
if (day == 2)
{
   Console.WriteLine($"Вторник"); 
}
if (day == 3)
{
   Console.WriteLine($"Среда"); 
}
if (day == 4)
{
   Console.WriteLine($"Четверг"); 
}
if (day == 5)
{
   Console.WriteLine($"Понедельник"); 
}
if (day == 6)
{
   Console.WriteLine($"Суббота"); 
}
if (day == 7)
{
   Console.WriteLine($"Воскресенье");  
}