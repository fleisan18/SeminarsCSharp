// 68. Показать натуральные числа от M до N, N и M заданы
string ShowNumbers(int m, int n)
{
    if (m == n) return $"{n}";
    else
    {
        if (m > n) return $"{m} {ShowNumbers(m - 1, n)}";
        else return $"{m} {ShowNumbers(m + 1, n)}";
    }
}
System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(ShowNumbers(M, N));

