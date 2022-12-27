// 84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа. 
// Вычислить сумму цифр введенного числа

string s = Console.ReadLine();

int sum = 0;
bool isNumber = true;
foreach(char c in s)
{
    if (char.IsDigit(c))
    {
        sum = sum + Convert.ToInt32(c) - Convert.ToInt32('0');
    } 
    else
    {
        isNumber = false;
    }
}

if (isNumber)
{
        System.Console.WriteLine($"Целое число. С суммой цифр {sum}");
}
else
    {
    System.Console.WriteLine("Не целое число");
} 