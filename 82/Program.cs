// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
    if (s[i] == Convert.ToChar(46))
    {
        System.Console.WriteLine(i);
    }

