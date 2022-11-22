// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int quarter=Convert.ToInt32(Console.ReadLine());
Console.OutputEncoding = System.Text.Encoding.UTF8;

if (quarter == 1)
{
    Console.WriteLine("x = (0 - ∞), y = (0 - ∞)");
}
else if (quarter == 2)
{
    Console.WriteLine("x = (-∞ - 0), y = (0 - ∞)");
}
else if (quarter == 3)
{
    Console.WriteLine("x = (-∞ - 0), y = (-∞ - 0)");
}
else
{
    Console.WriteLine("x = (0 - ∞), y = (-∞ - 0)");
}
  