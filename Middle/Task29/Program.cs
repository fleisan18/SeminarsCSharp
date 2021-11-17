// 29.Написать программу вычисления произведения чисел от 1 до N
int N = 5;
int Method29(int n)
{
    int number = 1;
    for(int i=1; i<=n; i++)
    {
        number = number * i;
    }
    return number;
}
Console.WriteLine($"Сумма чисел от 1 до {N} = {Method29(N)}");