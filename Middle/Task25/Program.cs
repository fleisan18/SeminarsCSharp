// 25. Найти сумму чисел от 1 до А
int A = 5;
int Sum(int A)
{
    int sum = 0;
    for(int i=1; i<=A; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {Sum(A)}");