// 28. Подсчитать сумму цифр в числе
int N = new Random().Next(0,1000);
int Sum(int n)
{
    int sum = 0;
    while(n!=0)
    {
        sum+=n%10;
        n=n/10;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе {N} = {Sum(N)}");
