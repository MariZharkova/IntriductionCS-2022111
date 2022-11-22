// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели: ");
int day=Convert.ToInt32(Console.ReadLine());

if ((day > 0)&(day < 6))
{
    Console.WriteLine($"Будни");
}
else if (day == 6 | day == 7)
{
    Console.WriteLine($"Выходной");
}
else
{
    Console.WriteLine($"Такого дня недели не существует");
}



