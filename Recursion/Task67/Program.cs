// 67. Показать натуральные числа от N до 1, N задано
string ShowNumbers(int n)
{
    if (n == 1) return "1";
    else return $" {n} {ShowNumbers(n - 1)}";
}
System.Console.WriteLine(ShowNumbers(15));

