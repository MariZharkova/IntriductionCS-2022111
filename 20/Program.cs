//20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У,
// причем X ≠ 0 и Y ≠ 0

Console.Write("Введите x: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y=Convert.ToInt32(Console.ReadLine());


if ((x > 0) & (y > 0))
{
    Console.WriteLine("1 четверть");
}
else if ((x < 0) & (y > 0))
{
    Console.WriteLine("2 четверть");
}
else if ((x < 0) & (y < 0))
{
    Console.WriteLine("3 четверть");
}
else
{
    Console.WriteLine("4 четверть");
}

