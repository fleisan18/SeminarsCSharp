// 66. Показать натуральные числа от 1 до N, N задано
string ShowNumbers(int n)
{
    if (n == 1) return "1";
    else return $"{ShowNumbers(n - 1)} {n}";
}
System.Console.WriteLine(ShowNumbers(15));
