// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string s = Console.ReadLine();
char symbol = Convert.ToChar(Console.ReadLine());

int i = 0;
foreach(char c in s)
{
    if (c == symbol)
    {
        i++;
    }
}
System.Console.WriteLine($"{i}");
